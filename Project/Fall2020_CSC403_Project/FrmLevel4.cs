using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel4 : FrmLevelBase
    {
        public SoundPlayer Level4Music;
        public static Vector2 rightDoorSpawn = new Vector2(1048, 443);
        public static Vector2 leftDoorSpawn = new Vector2(101, 384);

        public FrmLevel4(Player player) : base(player, "level4")
        {
            InitializeComponent();
            Level4Music = new SoundPlayer(Resources.sewer);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level4Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level4Music.Stop();
        }

        public void FrmLevel4_Load(object sender, EventArgs e)
        {
            var enemySlime = new Enemy(new Vector2(485, 450), EnemyCharacter.Slime, 1, "slime_level4");
            var enemyRat = new Enemy(new Vector2(250, 80), EnemyCharacter.Rat, 2, "rat_level4"); 

            enemies = new List<Enemy> { enemySlime, enemyRat }; 

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