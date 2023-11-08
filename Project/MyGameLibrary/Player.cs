using System.Collections.Generic;

namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public Dictionary<string, int> items;
        public Player(Vector2 initPos, Collider collider, int level) : base(initPos, collider, level)
        {
            items = new Dictionary<string, int>();
            items.Add("Bow", 0);
            items.Add("Arrows", 0);
            items.Add("Potions", 0);
            items.Add("Keys", 0);
        }

        public void SavePlayerState()
        {

        }
    }
}
