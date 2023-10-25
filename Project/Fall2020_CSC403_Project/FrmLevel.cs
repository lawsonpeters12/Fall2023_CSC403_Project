using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        // Tracks the keys currently being pressed down.
        private List<Keys> keysPressed = new List<Keys>();

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public FrmLevel()
        {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), 3);
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 3, false);
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 1, false);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 2, false);
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

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
                if (enemyPoisonPacket.Health <= 0)
                {
                    BodyCleanUp(enemyPoisonPacket);
                }
                else
                {
                    Fight(enemyPoisonPacket);
                }
            }
            else if (HitAChar(player, enemyCheeto))
            {
                if (enemyCheeto.Health  <= 0)
                {
                    BodyCleanUp(enemyCheeto);
                }
                else
                {
                    Fight(enemyCheeto);
                }
            }
            else if (HitAChar(player, bossKoolaid))
            {
                if (bossKoolaid.Health <= 0)
                {
                    BodyCleanUp(bossKoolaid);
                }
                else
                {
                    Fight(bossKoolaid);
                }
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        public void BodyCleanUp(Enemy enemy)
        {

            if (enemy.Health <= 0)
            {
                if (enemy == bossKoolaid)
                {
                    picBossKoolAid.Dispose();
                    bossKoolaid.Collider.MovePosition(0, 0);
                    this.Invalidate();
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
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();
            keysPressed.Clear();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }

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
                SavePlayerState();
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
                    FormPauseMenu = new FormPauseMenu();
                    FormPauseMenu.Show();
                    break;
                case Keys.I:
                    FormInventory = new FormInventory();
                    FormInventory.Show();
                    break;

            }
        }

        private void SavePlayerState()
        {
            string saveLocation = @"..\..\Save.txt";
            
            try
            {
                if (File.Exists(saveLocation))
                {
                    File.Delete(saveLocation);
                }

                // Save file creation
                using (StreamWriter sw = File.CreateText(saveLocation))
                {
                    //save player states
                    sw.WriteLine($"MaxHealth: {player.MaxHealth}");
                    sw.WriteLine($"Health: {player.Health}");
                    sw.WriteLine($"Location: {player.Position}");
                    sw.WriteLine($"Level: {player.Level}");
                    sw.WriteLine($"Experience: {player.Experience}");
                    sw.WriteLine($"Strength: {player.strength}");
                    
                    //save enemy states
                    sw.WriteLine($"Poison Packet defeated: {enemyPoisonPacket.isDeafeated}");
                    sw.WriteLine($"Cheeto defeated: {enemyCheeto.isDeafeated}");
                    sw.WriteLine($"Boss defeated: {bossKoolaid.isDeafeated}");
                }

                using (StreamReader sr = File.OpenText(saveLocation))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine((Ex.ToString()));
            }
        }
        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}