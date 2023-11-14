using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel5 : FrmLevelBase
    {
        public static Vector2 brightDoorSpawn = new Vector2(1052, 425);
        public static Vector2 trightDoorSpawn = new Vector2(1056, 126);
        public FrmLevel5(Player player) : base (player, "level5")
        {
            InitializeComponent();
        }

        public void FrmLevel5_Load(object sender, EventArgs e)
        {
            var enemyCrawly = new Enemy(new Vector2(123, 250), EnemyCharacter.SewerCrawly, 5, "sewercrawly_level5");
            var enemySpider = new Enemy(new Vector2(675, 450), EnemyCharacter.Spider, 5, "sewerspider_level5");

            enemies = new List<Enemy> { enemySpider, enemyCrawly };

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