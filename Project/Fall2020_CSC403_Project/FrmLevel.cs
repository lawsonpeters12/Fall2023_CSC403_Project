using Fall2020_CSC403_Project.code;
using System;
using System.Media;
using System.Collections.Generic;
using System.Windows.Forms;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : FrmLevelBase
    {
        public SoundPlayer Level1Music; 
        public static Vector2 frontDoorSpawn = new Vector2(616, 411);
        public static Vector2 rightDoorSpawn = new Vector2(1012, 378);
        public static Vector2 leftDoorSpawn = new Vector2(120, 385);
        public static Vector2 topDoorSpawn = new Vector2(650, 119);
        
        // Sets the player's Character to what was chosen in Character Select
        public FrmLevel(Player player) : base (player, "level1")
        {
            InitializeComponent();
            Level1Music = new SoundPlayer(Resources.roaming3);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            Level1Music.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            Level1Music.Stop();
        }

        public void FrmLevel_Load(object sender, EventArgs e)
        {
            // Sample enemies
            var enemyGhost = new Enemy(new Vector2(100, 350), EnemyCharacter.Ghost, 1, "ghost_level1");
            enemies = new List<Enemy>{ enemyGhost };

            // Sample items
            var testItem = new Item(new Vector2(500, 500), ItemType.Arrow, "testItem1_level1");
            var testItem2 = new Item(new Vector2(167, 250), ItemType.Bow, "testItem2_level1");
            var healthPotion = new Item(new Vector2(1363, 281), ItemType.HealingPotion, "healingPotion_lvl1");
            items = new List<Item>{testItem, testItem2, healthPotion};
            
            PictureBox pic = Controls.Find("doorToLvl2", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel2.leftDoorSpawn, new FrmLevel2(player)));

            pic = Controls.Find("doorToLvl4", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel4.rightDoorSpawn, new FrmLevel4(player)));
            
            pic = Controls.Find("doorToLvl8", true)[0] as PictureBox;
            doors.Add(Door.MakeDoor(pic, FrmLevel8.bottomDoorSpawn, new FrmLevel8(player)));
            
            LevelSetup();
            Game.player = player;
            DoubleBuffered = true;
        }
        
        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            Tick();
        }

								private void doorToLvl8_Click(object sender, EventArgs e)
								{

								}

								private void picWall9_Click(object sender, EventArgs e)
								{

								}

								private void picWall8_Click(object sender, EventArgs e)
								{

								}

								private void doorToLvl2_Click(object sender, EventArgs e)
								{

								}

								private void picWall11_Click(object sender, EventArgs e)
								{

								}

								private void frontDoor_Click(object sender, EventArgs e)
								{

								}
				}
}