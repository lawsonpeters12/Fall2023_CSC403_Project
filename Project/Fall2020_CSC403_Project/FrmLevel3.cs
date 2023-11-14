using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel3 : FrmLevelBase
    {
        public SoundPlayer Level3Music;
        public static Vector2 bottomDoorSpawn = new Vector2(966, 428);

        public FrmLevel3(Player player) : base(player, "level3")
        {
            InitializeComponent();

            Level3Music = new SoundPlayer(Resources.roaming3);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level3Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level3Music.Stop();
        }

        public void FrmLevel3_Load(object sender, EventArgs e)
        {
            // Sample enemies
            var enemyGhost = new Enemy(new Vector2(500,375), EnemyCharacter.Ghost, 7, "ghost_level3");
            var enemyHellBeast = new Enemy(new Vector2(125,225), EnemyCharacter.HellBeast, 5, "hellBeast_level3");

            enemies = new List<Enemy> { enemyGhost, enemyHellBeast, };

            var key1 = new Item(new Vector2(125, 100), ItemType.Key, "key1_lvl3");
            items = new List<Item> {key1};

            PictureBox pic = Controls.Find("doorToLvl2", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel2.topDoorSpawn, new FrmLevel2(player)));
            
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