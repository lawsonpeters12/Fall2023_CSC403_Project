﻿using System.Collections.Generic;
using System.Drawing;


namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public Dictionary<string, int> items;
        public PlayerCharacter PlayerModel { get; set; }
        public List<string> DefeatedEnemies { get; set; }
        public List<string> PickedUpItems { get; set; }
        public string LevelName { get; set; }

        public Player(Vector2 initPos, int level, PlayerCharacter playerModel, List<string> defeatedEnemies, List<string> pickedUpItems) : base(initPos, new Collider(new Rectangle(new Point((int)initPos.x, (int)initPos.y), new Size(50, 100))), level)
        {
            items = new Dictionary<string, int>();
            items.Add("Bow", 0);
            items.Add("Arrows", 0);
            items.Add("Potions", 0);
            items.Add("Keys", 0);
            PlayerModel = playerModel;
            DefeatedEnemies = defeatedEnemies;
            PickedUpItems = pickedUpItems;
        }

    }
    
    public enum PlayerCharacter
    {
        Johnny,
        Jimmy,
        Jenny
    }
}
