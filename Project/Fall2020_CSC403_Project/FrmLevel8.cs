using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel8 : FrmLevelBase
    {
        public SoundPlayer Level8Music;
        public static Vector2 bottomDoorSpawn = new Vector2(587, 419);
        public static Vector2 leftDoorSpawn = new Vector2(110, 299);
        public static Vector2 topDoorSpawn = new Vector2(593, 115);

        public FrmLevel8(Player player) : base(player, "level8")
        {
            InitializeComponent();
            Level8Music = new SoundPlayer(Resources.roaming3);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level8Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level8Music.Stop();
        }

        public void FrmLevel8_Load(object sender, EventArgs e)
        {
            PictureBox pic = Controls.Find("doorToLvl1", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel.topDoorSpawn, new FrmLevel(player)));
            
            pic = Controls.Find("doorToLvl7", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel7.rightDoorSpawn, new FrmLevel7(player)));

            pic = Controls.Find("doorToLvl9", true)[0] as PictureBox;
            if (player.items["Keys"] >= 2)
            {
                doors.Add(Door.MakeDoor(pic, FrmLevel9.bottomDoorSpawn, new FrmLevel9(player)));
            }
            else doors.Add(Door.MakeDoor(pic, new Vector2(player.Position.x, player.Position.y), null));
            
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