using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel5 : FrmLevelBase
    {
        public SoundPlayer Level5Music;
        public static Vector2 brightDoorSpawn = new Vector2(1052, 425);
        public static Vector2 trightDoorSpawn = new Vector2(1056, 126);

        public FrmLevel5(Player player) : base(player, "level5")
        {
            InitializeComponent();
            Level5Music = new SoundPlayer(Resources.sewer);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level5Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level5Music.Stop();
        }

        public void FrmLevel5_Load(object sender, EventArgs e)
        {
            var enemyCrawly = new Enemy(new Vector2(123, 250), EnemyCharacter.SewerCrawly, 1, "sewercrawly_level5");

            enemies = new List<Enemy> { enemyCrawly };


            var healthPotion = new Item(new Vector2(123, 100), ItemType.HealingPotion, "healingPotion_level5");
            items = new List<Item> { healthPotion };

            PictureBox pic = Controls.Find("doorToLvl4", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel4.leftDoorSpawn, new FrmLevel4(player)));
            
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

								private void picWall2_Click(object sender, EventArgs e)
								{

								}

								private void picWall4_Click(object sender, EventArgs e)
								{

								}
				}
}