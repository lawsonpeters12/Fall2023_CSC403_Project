using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel8 : FrmLevelBase
    {
        public static Vector2 bottomDoorSpawn = new Vector2(587, 419);
        public static Vector2 leftDoorSpawn = new Vector2(110, 299);
        public static Vector2 topDoorSpawn = new Vector2(593, 115);
        public FrmLevel8(Player player) : base(player, "level8")
        {
            InitializeComponent();
        }

        public void FrmLevel8_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl1", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel.topDoorSpawn, new FrmLevel(player)));
            
            pic = Controls.Find("doorToLvl7", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel7.rightDoorSpawn, new FrmLevel7(player)));
            
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