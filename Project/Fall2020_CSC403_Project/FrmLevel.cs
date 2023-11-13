﻿using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : FrmLevelBase
    {
        public static Vector2 frontDoorSpawn = new Vector2(747, 596);
        public static Vector2 rightDoorSpawn = new Vector2(1262, 502);
        public static Vector2 leftDoorSpawn = new Vector2(133, 503);
        public static Vector2 topDoorSpawn = new Vector2(763, 119);
        
        // Sets the player's Character to what was chosen in Character Select
        public FrmLevel(Player player) : base (player, "level1")
        {
            InitializeComponent();
        }
        
        public void FrmLevel_Load(object sender, EventArgs e)
        {
            // Sample enemies
            var bossKoolaid = new Enemy(new Vector2(1071, 117), EnemyCharacter.KoolAid, 2, "koolaid_level1");
            var enemyCheeto = new Enemy(new Vector2(1256, 497), EnemyCharacter.EnemyCheeto, 2, "cheeto_level1");
            var enemyPoisonPacket = new Enemy(new Vector2(167, 250), EnemyCharacter.PoisonPacket, 1, "packet_level1");
            enemies = new List<Enemy>{bossKoolaid, enemyCheeto, enemyPoisonPacket};

            // Sample items
            var testItem = new Item(new Vector2(500, 500), ItemType.Arrow, "testItem1_level1");
            var testItem2 = new Item(new Vector2(600, 500), ItemType.Bow, "testItem2_level1");
            items = new List<Item>{testItem, testItem2};
            
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