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
    
    public partial class FrmLevel : FrmLevelBase
    {
        public static Vector2 spawnPoint = new Vector2(747, 596);
        
        protected override Player player { get; set; }
        protected override PictureBox playerPicture => picPlayer;
        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;
        private Character door;
        private Character bow;
        protected FormPauseMenu FormPauseMenu;
        protected FormInventory FormInventory;
        private FormWinScreen FormWinScreen;
        private FrmLevel2 Level2;
        private FormCharacterSelect FormCharacterSelect = new FormCharacterSelect();
        protected String Character;


        // Tracks the keys currently being pressed down.
        private List<Keys> keysPressed = new List<Keys>();

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        
        // Sets the player's Character to what was chosen in Character Select
        public FrmLevel(Player player)
        {
            InitializeComponent();
            this.player = player;
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
            
            LevelSetup();
            
            // initialization of defaults or saved data
            
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 2,
                bossIsDefeated);
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket),
                CreateCollider(picEnemyPoisonPacket, PADDING), 1, poisonIsDefeated);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 2,
                cheetoIsDefeated);

            
            //player.Health = playerHealth;
            //player.Experience = playerExperience;

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

            // Places the images and colliders for the walls
            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            door = new Character(CreatePosition(doorToLvl2), CreateCollider(doorToLvl2, PADDING));

            bow = new Character(CreatePosition(pictureBox4), CreateCollider(pictureBox4, PADDING));

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

            if (HitADoor(player))
            {
                Level2 = new FrmLevel2(player);
                // move player position to new door
                player.Position = FrmLevel2.leftDoor;
                Level2.Show();
                this.Close();
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
            else if (HitAChar(player, bow))
            {
                player.items["Bow"] = 1;
                player.items["Arrows"] = 5;
                pictureBox4.Visible = false;
                bow.Collider.MovePosition(0, 0);
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
                pictureBox4.Visible = true;
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

        private bool HitADoor(Character c)
        {
            bool hitADoor = c.Collider.Intersects(door.Collider);

            // returns which door you are hitting
            return hitADoor;
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

        private void picEnemyPoisonPacket_Click(object sender, EventArgs e)
        {

        }

        private void picWall10_Click(object sender, EventArgs e)
        {

        }

        private void doorToLvl4_Click(object sender, EventArgs e)
        {

        }
    }
}