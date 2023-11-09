using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : FrmLevelBase
    {
        public static Vector2 leftDoor = new Vector2(149, 490);
        protected override Player player { get; set; }
        protected override PictureBox playerPicture => picPlayer;

        protected FormPauseMenu FormPauseMenu;
        protected FormInventory FormInventory;
        private Character[] walls;
        public FrmLevel2(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        public void FrmLevel2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 8;
            //player.Position = CreatePosition(picPlayer);

            LevelSetup();
            
            this.FormBorderStyle = FormBorderStyle.None;
            walls = InitializeWalls(NUM_WALLS);

            Game.player = player;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
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
    }
}