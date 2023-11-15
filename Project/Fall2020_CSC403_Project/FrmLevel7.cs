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
            var key2 = new Item(new Vector2(175, 250), ItemType.Key2, "key2_lvl7");
            var healthPotion = new Item(new Vector2(750, 0), ItemType.HealingPotion, "healingPotion_lvl7");
            items = new List<Item> { key2, healthPotion };

            var enemyMiniBoss = new Enemy(new Vector2(175, 80), EnemyCharacter.miniBoss,7, "miniBoss_level7");
            var enemyGhost = new Enemy(new Vector2(650, 350), EnemyCharacter.Ghost, 3, "ghost_level7");
            enemies = new List<Enemy> { enemyMiniBoss, enemyGhost };

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