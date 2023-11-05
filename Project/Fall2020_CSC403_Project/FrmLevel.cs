using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Data;
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
        protected FormPauseMenu FormPauseMenu;
        protected FormInventory FormInventory;
        private FormWinScreen FormWinScreen;
        private FormCharacterSelect FormCharacterSelect = new FormCharacterSelect();
        protected String Character;
        protected Image picPeter = Properties.Resources.petah_nobg;
        protected Image picSponge = Properties.Resources.thesponge_nobg;
        protected Image picWormy = Properties.Resources.wormy_nobg;


        // Tracks the keys currently being pressed down.
        private List<Keys> keysPressed = new List<Keys>();

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        
        // Sets the player's Character to what was chosen in Character Select
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
            
            // default game data
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
                // save file found
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
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 2,
                bossIsDefeated);
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket),
                CreateCollider(picEnemyPoisonPacket, PADDING), 1, poisonIsDefeated);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 2,
                cheetoIsDefeated);

            
            player.Health = playerHealth;
            player.Experience = playerExperience;

            // Sets appropriate enemy poison packet image properties
            picEnemyPoisonPacket.Image = Properties.Resources.enemy_poisonpacket;
            picEnemyPoisonPacket.BackgroundImage = Properties.Resources.enemy_poisonpacket;
            picEnemyPoisonPacket.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyPoisonPacket.Color = Color.Green;
            picEnemyPoisonPacket.SendToBack();
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;

            // Sets appropriate enemy cheeto image properties
            picEnemyCheeto.Image = Properties.Resources.enemy_cheetos;
            picEnemyCheeto.BackgroundImage = Properties.Resources.enemy_cheetos;
            picEnemyCheeto.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            picEnemyCheeto.SendToBack();
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            // Sets appropriate BossKoolAid image properties
            picBossKoolAid.Image = Properties.Resources.enemy_koolaid;
            picBossKoolAid.BackgroundImage = Properties.Resources.enemy_koolaid;
            picBossKoolAid.SizeMode = PictureBoxSizeMode.StretchImage;
            bossKoolaid.Color = Color.Red;
            picBossKoolAid.SendToBack();
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;


            this.FormBorderStyle = FormBorderStyle.None;

            // Sets the image of the player's character to whoever was chosen in Character Select
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

            // Places the images and colliders for the walls
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

            // Removes bodies of enemies if they had already been defeated when loading from a save state.
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


        protected Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        protected Collider CreateCollider(PictureBox pic, int padding)
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

        // Tracks in-game time
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

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        // Removes the image annd moves the collider of an enemy.
        public void BodyCleanUp(Enemy enemy)
        {
            if (enemy == bossKoolaid)
            {
                picBossKoolAid.Image = null;
                picBossKoolAid.BackgroundImage = null;
                bossKoolaid.Collider.MovePosition(0, 0);
                this.Invalidate();

                // If boss is defeated, win screen is pulled up.
                FormWinScreen = new FormWinScreen(this);
                FormWinScreen.Show();
                FormWinScreen.FormBorderStyle = FormBorderStyle.None;
            }
            else if (enemy == enemyCheeto)
            {
                picEnemyCheeto.Image = null;
                picEnemyCheeto.BackgroundImage = null;
                enemyCheeto.Collider.MovePosition(0, 0);
                this.Invalidate();
            }
            else
            {
                picEnemyPoisonPacket.Image = null;
                picEnemyPoisonPacket.BackgroundImage = null; 
                enemyPoisonPacket.Collider.MovePosition(0, 0);
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

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, Character, this);
            frmBattle.Show();
            keysPressed.Clear();

            // Creates Timer that tracks the enemy's health in combat. When the enemy reaches 0 health, it calls BodyCleanUp to remove the enemy's body
            Timer healthCheckTimer = new Timer();
            healthCheckTimer.Interval = 200;
            healthCheckTimer.Tick += (sender, e) => CheckEnemyHealth(enemy, healthCheckTimer);
            healthCheckTimer.Start();
        }

        private void CheckEnemyHealth(Enemy enemy, Timer timer)
        {
            if (enemy.Health <= 0)
            {
                // Removes enemy's body if enemy runs out of health
                BodyCleanUp(enemy);
                timer.Stop();
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            // keysPressed tracks all keys currently being held down
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
            // Handles orthogonal movements
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
                // Opens pause menu if Esc key is pressed.
                case Keys.Escape:
                    FormPauseMenu = new FormPauseMenu(this);
                    FormPauseMenu.Show();
                    break;
                // Opens inventory if I key is pressed.
                case Keys.I:
                    FormInventory = new FormInventory(Character);
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