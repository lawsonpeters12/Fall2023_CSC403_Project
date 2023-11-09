using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    // should know about pause and inventory
    public class FrmLevelBase : Form
    {
        // level specific things
        protected virtual Player player { get; set; }
        protected virtual PictureBox playerPicture { get; }

        private List<Keys> keysPressed = new List<Keys>();
        private FormPauseMenu PauseMenu;
        private FormInventory Inventory;
        private Character[] walls;
        private Image PlayerSprite
        {
            get
            {
                switch (player.PlayerModel)
                {
                    case PlayerCharacter.Jenny:
                        return Properties.Resources.jenny_nobg;
                    case PlayerCharacter.Jimmy:
                        return Properties.Resources.jimmy_nobg;
                    case PlayerCharacter.Johnny:
                        return Properties.Resources.johnny_nobg;
                }

                return Properties.Resources.johnny_nobg; // base case 
            }
        }

        public FrmLevelBase()
        {
            KeyUp += BaseKeyUp;
            KeyDown += BaseKeyDown;
            
        }
        
        public void LevelSetup()
        {
            playerPicture.Location = new Point((int)player.Position.x, (int)player.Position.y);
            playerPicture.Image = PlayerSprite;
            playerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            playerPicture.Size = player.Collider.rect.Size;
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
        
        protected Character[] InitializeWalls(int numWalls)
        {
            walls = new Character[numWalls];
            for (int w = 0; w < numWalls; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, 7));
            }
        
            return walls;
        }
        
        // initialize doors, add a tag to each door to tell which level it is going to

        protected void BaseKeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            player.ResetMoveSpeed();
        }
        
        protected void BaseKeyDown(object sender, KeyEventArgs e)
        {
            // keysPressed tracks all keys currently being held down
            if (!keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Add(e.KeyCode);
            }

            // Handles diagonal movements
            if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Right)) ||
                keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.D))
            {
                player.GoUpRight();
            }
            else if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Left)) ||
                     keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.A))
            {
                player.GoUpLeft();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Right)) ||
                     keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.D))
            {
                player.GoDownRight();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Left)) ||
                     keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.A))
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
                        PauseMenu = new FormPauseMenu(player);
                        PauseMenu.Show();
                        break;
                    // Opens inventory if I key is pressed.
                    case Keys.I:
                        Inventory = new FormInventory(player.PlayerModel.ToString());
                        Inventory.Show();
                        break;
                }
            }
        }

    }
    // helper function that takes in enemy info and inits it or sumn
}