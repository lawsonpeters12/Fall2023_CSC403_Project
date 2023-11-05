using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;
        private FormPauseMenu FormPauseMenu;
        private FormInventory FormInventory;
        private FormWinScreen FormWinScreen;
        private FormCharacterSelect FormCharacterSelect = new FormCharacterSelect();
        public String Character;
        private Image picPeter = Properties.Resources.petah_nobg;
        private Image picSponge = Properties.Resources.thesponge_nobg;
        private Image picWormy = Properties.Resources.wormy_nobg;

        private Item healthPotion;



        // Tracks the keys currently being pressed down.
        private List<Keys> keysPressed = new List<Keys>();

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        public FrmLevel(String ChosenCharacter)
        {
            InitializeComponent();
            Character = ChosenCharacter;
        }
        private string saveLocation = @"..\..\Save.txt";
        private bool loadGame;
        
        public void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;
            
            // default load data
            var playerHealth = 20;
            Vector2 loadLocation = CreatePosition(picPlayer);
            var playerLevel = 1;
            var playerExperience = 0;
            var poisonIsDefeated = false;
            var cheetoIsDefeated = false;
            var bossIsDefeated = false;
            
            // Loads save file
            if (loadGame)
            {
                // save found
                if (File.Exists(saveLocation))
                {
                    // replaces defaults with saved values
                    string[] saveInformation = GetSaveInfo();
                    Character = saveInformation[0];
                    playerHealth = int.Parse(saveInformation[1]);
                    var xPos = float.Parse(saveInformation[2]);
                    var yPos = float.Parse(saveInformation[3]);
                    loadLocation = new Vector2(xPos, yPos);
                    playerLevel = int.Parse(saveInformation[4]);
                    playerExperience = int.Parse(saveInformation[5]);
                    poisonIsDefeated = bool.Parse(saveInformation[6]);
                    cheetoIsDefeated = bool.Parse(saveInformation[7]);
                    bossIsDefeated = bool.Parse(saveInformation[8]);

                    loadGame = false;
                }
                // no save found, leave game in current state
                else
                {
                    return;
                }
            }
            
            // initialization of defaults or saved data 
            player = new Player(loadLocation, CreateCollider(picPlayer, PADDING), playerLevel);
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 3,
                bossIsDefeated);
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket),
                CreateCollider(picEnemyPoisonPacket, PADDING), 1, poisonIsDefeated);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 2,
                cheetoIsDefeated);
            
            healthPotion = new Item(CreatePosition(picHealthPot), CreateCollider(picHealthPot, PADDING));

                        
            player.Health = playerHealth;
            player.Experience = playerExperience;

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            healthPotion.Img = picHealthPot.BackgroundImage;
            this.FormBorderStyle = FormBorderStyle.None;

            if (Character == "Peter")
            {
                picPlayer.Image = picPeter;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "The Sponge")
            {
                picPlayer.Image = picSponge;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "Wormy")
            {
                picPlayer.Image = picWormy;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            if (poisonIsDefeated)
            {
                BodyCleanUp(enemyPoisonPacket);
            }
            if (cheetoIsDefeated)
            {
                BodyCleanUp(enemyCheeto);
            }
            if (bossIsDefeated)
            {
                BodyCleanUp(bossKoolaid);
            }           

        }


        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        // If key is released, removes it from keysPressed
        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }
                
            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket))
            {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto))
            {
                Fight(enemyCheeto);
            }
            else if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }

            // check collision with item
            if(HitAnItem(player, healthPotion))
            {
                PickupItem(healthPotion);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        public void BodyCleanUp(Enemy enemy)
        {
            if (enemy == bossKoolaid)
            {
                picBossKoolAid.Dispose();
                bossKoolaid.Collider.MovePosition(0, 0);
                this.Invalidate();
                FormWinScreen = new FormWinScreen();
                FormWinScreen.Show();
            }
            else if (enemy == enemyCheeto)
            {
                picEnemyCheeto.Dispose();
                enemyCheeto.Collider.MovePosition(0, 0);
                this.Invalidate();
            }
            else
            {
                picEnemyPoisonPacket.Dispose();
                enemyPoisonPacket.Collider.MovePosition(0, 0);
                this.Invalidate();
            }
        }
        // method to remove item from level 
        public void ItemCleanup(Item item)
        {
            if(item == healthPotion)
            {
                picHealthPot.Dispose();
                healthPotion.Collider.MovePosition(0, 0);
                this.Invalidate();
            }
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        //boolean to tell if player collides w item (2)
        
        private bool HitAnItem(Character you, Item item)
        {
            return you.Collider.Intersects(item.Collider);
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }
        // method to append item to player inventory when item is hit (2)
        private void PickupItem(Item item)
        {
            player.ResetMoveSpeed();
            player.MoveBack();

            ItemCleanup(item);
            
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, Character);
            frmBattle.Show();
            keysPressed.Clear();

            // Creates Timer that tracks the enemy's health in combat. When the enemy reaches 0 health, it cleans up the body
            Timer healthCheckTimer = new Timer();
            healthCheckTimer.Interval = 200;
            healthCheckTimer.Tick += (sender, e) => CheckEnemyHealth(enemy, healthCheckTimer);
            healthCheckTimer.Start();
        }

        private void CheckEnemyHealth(Enemy enemy, Timer timer)
        {
            if (enemy.Health <= 0)
            {
                BodyCleanUp(enemy);
                timer.Stop();
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Add(e.KeyCode);
            }

            // Handles diagonal movements
            if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Right)) || keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.D))
            {
                player.GoUpRight();
            }
            else if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Left)) || keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.A))
            {
                player.GoUpLeft();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Right)) || keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.D))
            {
                player.GoDownRight();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Left)) || keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.A))
            {
                player.GoDownLeft();
            }
            // Handle non-diagonal movements
            else
            {
                if (keysPressed.Contains(Keys.Left) || keysPressed.Contains(Keys.A))
                {
                    player.GoLeft();
                }
                if (keysPressed.Contains(Keys.Right) || keysPressed.Contains(Keys.D))
                {
                    player.GoRight();
                }
                if (keysPressed.Contains(Keys.Up) || keysPressed.Contains(Keys.W))
                {
                    player.GoUp();
                }
                if (keysPressed.Contains(Keys.Down) || keysPressed.Contains(Keys.S))
                {
                    player.GoDown();
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FormPauseMenu = new FormPauseMenu(this);
                    FormPauseMenu.Show();
                    break;
                case Keys.I:
                    if (Character == "Peter")
                    {
                        FormInventory = new FormInventory("Peter");
                       
                    }
                    if (Character == "The Sponge")
                    {
                        FormInventory = new FormInventory("The Sponge");
                    }
                    if (Character == "Wormy")
                    {
                        FormInventory = new FormInventory("Wormy");
                    }
                    FormInventory.Show();
                    break;
            }
        }

        public void SaveGameState()
        {
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            // Save file creation
            using (StreamWriter sw = File.CreateText(saveLocation))
            {
                //save player state
                sw.WriteLine(Character);
                sw.WriteLine(player.Health);
                sw.WriteLine(player.Position.x);
                sw.WriteLine(player.Position.y);
                sw.WriteLine(player.Level);
                sw.WriteLine(player.Experience);

                //save enemy states
                sw.WriteLine(enemyPoisonPacket.isDefeated);
                sw.WriteLine(enemyCheeto.isDefeated);
                sw.WriteLine(bossKoolaid.isDefeated);
            }

        }

        private string[] GetSaveInfo()
        {
            if (File.Exists(saveLocation))
            {
                var saveInformation = File.ReadAllLines(saveLocation);
                return saveInformation;
            }
            return null;
        }
        
        public void LoadGameState(object sender, EventArgs e)
        {
            loadGame = true;
            FrmLevel_Load(sender, e);
        }
        
        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}