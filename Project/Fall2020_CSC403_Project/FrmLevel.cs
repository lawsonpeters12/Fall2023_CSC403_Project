using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : FrmLevelBase
    {
        public static Vector2 frontDoorSpawn = new Vector2(747, 596);
        public static Vector2 rightDoorSpawn = new Vector2(1262, 502);
        public static Vector2 leftDoorSpawn = new Vector2(133, 503);
        public static Vector2 topDoorSpawn = new Vector2(763, 119);
        
        private Character bow;
        
        // Sets the player's Character to what was chosen in Character Select
        public FrmLevel(Player player) : base (player, "level1")
        {
            InitializeComponent();
        }
        
        public void FrmLevel_Load(object sender, EventArgs e)
        {
            // pass collider size Vector2, might want to make it bigger/smaller than image size
            var bossKoolaid = new Enemy(new Vector2(1071, 117), EnemyCharacter.KoolAid, 2, "koolaid_level1");
            var enemyCheeto = new Enemy(new Vector2(1256, 497), EnemyCharacter.EnemyCheeto, 2, "cheeto_level1");
            var enemyPoisonPacket = new Enemy(new Vector2(167, 250), EnemyCharacter.PoisonPacket, 1, "packet_level1");
            enemies = new List<Enemy>{bossKoolaid, enemyCheeto, enemyPoisonPacket};
            
            PictureBox pic = Controls.Find("picDoor0", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel2.leftDoorSpawn, new FrmLevel2(player)));
            
            LevelSetup();
            Game.player = player;
            DoubleBuffered = true;
        }
        
        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            Tick();
            // if (HitAChar(player, bow))
            // {
            //     player.items["Bow"] = 1;
            //     player.items["Arrows"] = 5;
            //     pictureBox4.Visible = false;
            //     bow.Collider.MovePosition(0, 0);
            // }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void picWall3_Click(object sender, EventArgs e)
        {

        }

        private void frontDoor_Click(object sender, EventArgs e)
        {

        }
    }
}