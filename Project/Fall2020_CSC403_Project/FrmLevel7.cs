using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel7 : FrmLevelBase
    {
        public static Vector2 rightDoorSpawn = new Vector2(1265, 349);
        public static Vector2 bottomDoorSpawn = new Vector2(1141, 683);
        public FrmLevel7(Player player) : base (player, "level7")
        {
            InitializeComponent();
        }

        public void FrmLevel7_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl8", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel8.leftDoorSpawn, new FrmLevel8(player)));

            pic = Controls.Find("doorToLvl6", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel6.topDoorSpawn, new FrmLevel6(player)));
            
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
				}
}