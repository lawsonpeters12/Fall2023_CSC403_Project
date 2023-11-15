using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel7 : FrmLevelBase
    {
        public SoundPlayer Level7Music;
        public static Vector2 rightDoorSpawn = new Vector2(1068, 239);
        public static Vector2 bottomDoorSpawn = new Vector2(287, 430);

        public FrmLevel7(Player player) : base(player, "level7")
        {
            InitializeComponent();
            Level7Music = new SoundPlayer(Resources.roaming3);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level7Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level7Music.Stop();
        }

        public void FrmLevel7_Load(object sender, EventArgs e)
        {
            var key3 = new Item(new Vector2(750, 250), ItemType.Key, "key3_lvl9");
            items = new List<Item> { key3 };

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

    }
}