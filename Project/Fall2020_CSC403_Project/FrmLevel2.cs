using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;

        protected FormPauseMenu FormPauseMenu;
        protected FormInventory FormInventory;
        private Character[] walls;
        protected String Character;
        protected Image picJohnny = Properties.Resources.johnny_nobg;
        protected Image picJimmy = Properties.Resources.jimmy_nobg;
        protected Image picJenny = Properties.Resources.jenny_nobg;

        private List<Keys> keysPressed = new List<Keys>();
        public FrmLevel2(String ChosenCharacter, Player player1)
        {
            InitializeComponent();
            Character = ChosenCharacter;
            player = player1;
        }

        public void FrmLevel2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 2;
            player.Position = CreatePosition(picPlayer);


            this.FormBorderStyle = FormBorderStyle.None;
            // Sets the image of the player's character to whoever was chosen in Character Select
            if (Character == "Johnny")
            {
                picPlayer.Image = picJohnny;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "Jimmy")
            {
                picPlayer.Image = picJimmy;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "Jenny")
            {
                picPlayer.Image = picJenny;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
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

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            player.ResetMoveSpeed();
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

            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
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

    }
}