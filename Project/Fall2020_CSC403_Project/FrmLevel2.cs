using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : FrmLevelBase
    {
        public static Vector2 leftDoorSpawn = new Vector2(119, 407);
        public static Vector2 topDoorSpawn = new Vector2(860, 114);
        
        public FrmLevel2(Player player) : base(player, "level2")
        {
            InitializeComponent();
        }

        public void FrmLevel2_Load(object sender, EventArgs e)
        {
            // Sample enemies
            var enemyHellHound = new Enemy(new Vector2(750, 100), EnemyCharacter.HellHound, 4, "hellhound_level2");
            enemies = new List<Enemy> { enemyHellHound };

            PictureBox pic = Controls.Find("picDoor0", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel.rightDoorSpawn, new FrmLevel(player)));

            pic = Controls.Find("picDoor1", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel3.bottomDoorSpawn, new FrmLevel3(player)));
            
            LevelSetup();
            Game.player = player;
            DoubleBuffered = true;
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            Tick();
        }

								private void picWall1_Click(object sender, EventArgs e)
								{

								}

								private void picWall6_Click(object sender, EventArgs e)
								{

								}
				}
}