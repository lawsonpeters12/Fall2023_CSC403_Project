using System.Drawing;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public class Item : Character
    {
        public ItemType ItemModel{ get; }
        public string Name { get; }

        public Size Size => new Size(50, 50);
        public Item(Vector2 initPos, ItemType itemModel, string name) : base(initPos, new Collider(new Rectangle(new Point((int)initPos.x, (int)initPos.y), new Size(50, 50))))
        {
            ItemModel = itemModel;
            Name = name;
        }

        public bool IsPickedUp(Player player)
        {
            return player.PickedUpItems.Contains(Name);
        }
    }

    public enum ItemType
    {
        HealingPotion,
        Bow,
        Arrow,
        Key
    }
}