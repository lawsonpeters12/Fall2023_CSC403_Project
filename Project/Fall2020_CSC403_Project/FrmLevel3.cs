using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel3 : FrmLevelBase
    {
        public static Vector2 bottomDoorSpawn = new Vector2(966, 428);
        public FrmLevel3(Player player) : base(player, "level3")
        {
            InitializeComponent();
        }

        public void FrmLevel3_Load(object sender, EventArgs e)
        {
            // Sample enemies
            var enemyGhost = new Enemy(new Vector2(500,375), EnemyCharacter.Ghost, 7, "ghost_level3");
            var enemyHellBeast = new Enemy(new Vector2(125,225), EnemyCharacter.HellBeast, 5, "hellBeast_level3");

            enemies = new List<Enemy> { enemyGhost, enemyHellBeast, };

            PictureBox pic = Controls.Find("doorToLvl2", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel2.topDoorSpawn, new FrmLevel2(player)));
            
            LevelSetup();
            Game.player = player;
            DoubleBuffered = true;
        }
        
        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            Tick();
        }
    }
}