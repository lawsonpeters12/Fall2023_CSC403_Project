using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel9 : FrmLevelBase
    {
        public static Vector2 bottomDoorSpawn = new Vector2(525, 410);

        public FrmLevel9(Player player) : base(player, "level9")
        {
            InitializeComponent();
        }

        public void FrmLevel9_Load(object sender, EventArgs e)
        {
            var Boss = new Enemy(new Vector2(750, 75), EnemyCharacter.Boss, 20, "boss_level9");
            enemies = new List<Enemy> { Boss, };

            PictureBox pic = Controls.Find("doorToLvl8", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel8.topDoorSpawn, new FrmLevel8(player)));

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