using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel6 : FrmLevelBase
    {
        public static Vector2 topDoorSpawn = new Vector2(1113, 109);
        public static Vector2 rightDoorSpawn = new Vector2(129, 566);
        public FrmLevel6(Player player) : base (player, "level6")
        {
            InitializeComponent();
        }

        public void FrmLevel6_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl7", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel7.bottomDoorSpawn, new FrmLevel7(player)));
            
            pic = Controls.Find("doorToLvl5", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel5.trightDoorSpawn, new FrmLevel5(player)));

            PictureBox gloopPic = Controls.Find("gooGloop0", true)[0] as PictureBox;
            gloops.Add(Gloop.MakeGloop(gloopPic));
            
            gloopPic = Controls.Find("gooGloop1", true)[0] as PictureBox;
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