using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Drawing;


namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public Dictionary<string, int> items;
        public PlayerCharacter PlayerModel { get; set; }
        public List<string> DefeatedEnemies { get; set; }
        public string LevelName { get; set; }

        public Player(Vector2 initPos, int level, PlayerCharacter playerModel, List<string> defeatedEnemies) : base(initPos, new Collider(new Rectangle(new Point((int)initPos.x, (int)initPos.y), new Size(47, 99))), level)
        {
            items = new Dictionary<string, int>();
            items.Add("Bow", 0);
            items.Add("Arrows", 0);
            items.Add("Potions", 0);
            items.Add("Keys", 0);
            PlayerModel = playerModel;
            DefeatedEnemies = defeatedEnemies;
        }

        // for reference
        public void SaveTest()
        {
            var playerSave = JsonConvert.SerializeObject(this);
            Console.WriteLine($"Player Object: {playerSave}");
            //this = JsonConvert.DeserializeObject<Player>(playerSave);
        }

    }
 // TODO LevelName enum
    public enum PlayerCharacter
    {
        Johnny, 
        Jimmy, 
        Jenny
    }
}
