using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel5 : FrmLevelBase
    {
        public static Vector2 brightDoorSpawn = new Vector2(1247, 547);
        public static Vector2 trightDoorSpawn = new Vector2(1384, 187);
        public FrmLevel5(Player player) : base (player, "level5")
        {
            InitializeComponent();
        }

        public void FrmLevel5_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl4", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel4.rightDoorSpawn, new FrmLevel4(player)));
            
            pic = Controls.Find("doorToLvl6", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel6.rightDoorSpawn, new FrmLevel6(player)));
            
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