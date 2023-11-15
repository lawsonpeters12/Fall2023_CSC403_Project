using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel9 : FrmLevelBase
    {
        public SoundPlayer Level9Music;
        public static Vector2 bottomDoorSpawn = new Vector2(525, 410);

        public FrmLevel9(Player player) : base(player, "level9")
        {
            InitializeComponent();
            Level9Music = new SoundPlayer(Resources.boss);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level9Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level9Music.Stop();
        }

        public void FrmLevel9_Load(object sender, EventArgs e)
        {
            var Boss = new Enemy(new Vector2(750, 100), EnemyCharacter.Boss, 10, "boss_level9");
            enemies = new List<Enemy> { Boss, };

            var key3 = new Item(new Vector2(750, 250), ItemType.Key3, "key3_lvl9");
            var healthPotion = new Item(new Vector2(150, 300), ItemType.HealingPotion, "healingPotion_level9");
            items = new List<Item> { healthPotion, key3 };

            PictureBox pic = Controls.Find("doorToLvl8", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel8.topDoorSpawn, new FrmLevel8(player)));

            this.Size = new System.Drawing.Size(1199, 618);
            this.CenterToScreen();

            LevelSetup();
            Game.player = player;
            DoubleBuffered = true;
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        // init player and enemy locations and walls
        // we're gonna have to hardcode the body cleanup for every enemy that i put in this room if we can't inherit frmlevel
        // gonna have to call the function anyways every time
        // default game data
    }
}