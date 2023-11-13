using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel4 : FrmLevelBase
    {
        public static Vector2 rightDoorSpawn = new Vector2(1048, 443);
        public static Vector2 leftDoorSpawn = new Vector2(101, 384);
        public FrmLevel4(Player player) : base (player, "level4")
        {
            InitializeComponent();
        }

        public void FrmLevel4_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl1", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel.leftDoorSpawn, new FrmLevel(player)));
            
            pic = Controls.Find("doorToLvl5", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel5.brightDoorSpawn, new FrmLevel5(player)));
            
            PictureBox gloopPic = Controls.Find("gooGloop0", true)[0] as PictureBox;
            gloops.Add(Gloop.MakeGloop(gloopPic));
            
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