using System.Collections.Generic;
using System.Drawing;
using System.Net.Security;
using System.Reflection;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public class FrmLevelBase : Form
    {
        // level specific things
        protected Player player { get; }
        protected List<Enemy> enemies { get; set; }
        public Color? FightColor { get; protected set; }
        protected List<Door> doors { get; set; }
        protected List<Gloop> gloops { get; set; }
        public List<Item> items { get; set; }

        public Image FightBackground
        {
            get
            {
                switch (LevelName)
                {
                    case "level1":
                    case "level2":
                    case "level3":
                    case "level7":
                    case "level8":
                        return Properties.Resources.backgroundBricks;
                    case "level4":
                    case "level5":
                    case "level6":
                        return Properties.Resources.sewerBackground;
                }
                return Properties.Resources.wall4;
            }
        }
        
        private Dictionary<Enemy, PictureBox> enemyBoxes;
        private Dictionary<Item, PictureBox> itemBoxes;
        private List<Keys> keysPressed = new List<Keys>();
        private FormPauseMenu PauseMenu;
        private FormInventory Inventory;
        private List<Character> walls = new List<Character>();
        private PictureBox playerPicture;
        private string LevelName;

        public FrmLevelBase(Player player, string levelName)
        {
            LevelName = levelName;
            this.player = player;
            enemies = new List<Enemy>();
            items = new List<Item>();
            FightColor = Color.Chocolate;
            doors = new List<Door>();
            gloops = new List<Gloop>();
            enemyBoxes = new Dictionary<Enemy, PictureBox>();
            itemBoxes = new Dictionary<Item, PictureBox>();
            KeyUp += BaseKeyUp;
            KeyDown += BaseKeyDown;
        }

        // DO NOT USE
        public FrmLevelBase(){}
        
        protected void LevelSetup()
        {
            player.LevelName = LevelName;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeWalls();
            InitializePlayer();
            foreach (var enemy in enemies)
            {
                InitializeEnemy(enemy);
            }
            foreach (var item in items)
            {
                InitializeItem(item);
            }
        }

        private void InitializePlayer()
        {
            playerPicture = new PictureBox
            {
                Name = "player",
                Size = player.Collider.rect.Size,
                Location = new Point((int)player.Position.x, (int)player.Position.y),
                Image = player.PlayerImage(),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(playerPicture);
        }
        private void InitializeEnemy(Enemy enemy)
        {
            if (enemy.IsDefeated(player)) return;
            var enemyPic = new PictureBox
            {
                Name = "enemy",
                Size = enemy.Size,
                Location = new Point((int)enemy.Position.x, (int)enemy.Position.y),
                Image = enemy.EnemyImage(),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(enemyPic);
            enemyBoxes.Add(enemy, enemyPic);
        }

        private void InitializeItem(Item item)
        {
            if (item.IsPickedUp(player)) return;
            var itemPic = new PictureBox()
            {
                Name = "item",
                Size = item.Size,
                Location = new Point((int)item.Position.x, (int)item.Position.y),
                Image = item.ItemImage(),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(itemPic);
            itemBoxes.Add(item, itemPic);
        }

        protected Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        protected Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }
        
        private void InitializeWalls()
        {
            foreach (var control in Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Name.StartsWith("picWall"))
                {
                    walls.Add(new Character(CreatePosition(pictureBox), CreateCollider(pictureBox, 7)));
                }
            }
        }

        protected void CleanupBody(Enemy enemy)
        {
            var pictureBox = enemyBoxes[enemy];
            if (pictureBox != null)
            {
                pictureBox.Visible = false;
            }
            enemy.Collider.MovePosition(0, 0);
            Invalidate();
        }

        protected void CleanupItem(Item item)
        {
            var pictureBox = itemBoxes[item];
            player.PickedUpItems.Add(item.Name);
            if (pictureBox != null)
            {
                pictureBox.Visible = false;
            }
            item.Collider.MovePosition(0,0);
            Invalidate();
        }

        protected void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            var frmBattle = FrmBattle.GetInstance(enemy, player, this);
            frmBattle.FightOver += (sender, args) =>
            {
                if (enemy.Health <= 0)
                {
                    // Removes enemy's body if enemy runs out of health
                    CleanupBody(enemy);
                }
            };
            keysPressed.Clear();
            frmBattle.Show();
        }

        protected void Tick()
        {
            if (!Visible) return;
            player.Move();
            var collisionObjects = new List<Character>();
            collisionObjects.AddRange(walls);
            collisionObjects.AddRange(doors);
            collisionObjects.AddRange(enemies);
            collisionObjects.AddRange(gloops);
            collisionObjects.AddRange(items);
            player.GO_INC = 3; // reset move speed out of gloop
            foreach (var collisionObject in collisionObjects)
            {
                if (player.Collider.Intersects((collisionObject.Collider)))
                {
                    switch (collisionObject)
                    {
                        case Enemy enemy when enemy.IsDefeated(player):
                        case Item item when item.IsPickedUp(player):
                            break;
                        case Enemy enemy:
                            Fight(enemy);
                            break;
                        case Door door:
                            player.Position = door.SpawnPoint;
                            door.TargetLevel.Show();
                            Close();
                            break;
                        case Gloop gloop:
                            gloop.MoveBack();
                            player.GO_INC = 1;
                            break;
                        case Item item when item.ItemModel == ItemType.Arrow:
                            player.items["Arrows"] += 2;
                            CleanupItem(item);
                            break;
                        case Item item when item.ItemModel == ItemType.Bow:
                            player.items["Bow"] ++;
                            player.items["Arrows"] += 5;
                            CleanupItem(item);
                            break;
                        case Item item when item.ItemModel == ItemType.HealingPotion:
                            player.items["Potions"] ++;
                            CleanupItem(item);
                            break;
                        case Item item when item.ItemModel == ItemType.Key:
                            player.items["Keys"] ++;
                            CleanupItem(item);
                            break;
                        // when we pick up an item do: player.PickedUpItems.Add(item.Name)
                        default:
                            player.MoveBack();
                            break;
                    }
                }
            }
            playerPicture.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }
        
        protected void BaseKeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            player.ResetMoveSpeed();
        }
        
        protected void BaseKeyDown(object sender, KeyEventArgs e)
        {
            // keysPressed tracks all keys currently being held down
            if (!keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Add(e.KeyCode);
            }

            // Handles diagonal movements
            if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Right)) ||
                keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.D))
            {
                player.GoUpRight();
            }
            else if ((keysPressed.Contains(Keys.Up) && keysPressed.Contains(Keys.Left)) ||
                     keysPressed.Contains(Keys.W) && keysPressed.Contains(Keys.A))
            {
                player.GoUpLeft();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Right)) ||
                     keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.D))
            {
                player.GoDownRight();
            }
            else if ((keysPressed.Contains(Keys.Down) && keysPressed.Contains(Keys.Left)) ||
                     keysPressed.Contains(Keys.S) && keysPressed.Contains(Keys.A))
            {
                player.GoDownLeft();
            }
            // Handles orthogonal movements
            else
            {
                if (keysPressed.Contains(Keys.Left) || keysPressed.Contains(Keys.A))
                {
                    player.GoLeft();
                }

                if (keysPressed.Contains(Keys.Right) || keysPressed.Contains(Keys.D))
                {
                    player.GoRight();
                }

                if (keysPressed.Contains(Keys.Up) || keysPressed.Contains(Keys.W))
                {
                    player.GoUp();
                }

                if (keysPressed.Contains(Keys.Down) || keysPressed.Contains(Keys.S))
                {
                    player.GoDown();
                }
                switch (e.KeyCode)
                {
                    // Opens pause menu if Esc key is pressed.
                    case Keys.Escape:
                        PauseMenu = new FormPauseMenu(player);
                        PauseMenu.Show();
                        break;
                    // Opens inventory if I key is pressed.
                    case Keys.I:
                        Inventory = new FormInventory(player.PlayerModel.ToString());
                        Inventory.Show();
                        break;
                }
            }
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmLevelBase
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FrmLevelBase";
            this.ResumeLayout(false);
        }
    }

    public static class Extensions
    {
        public static Image EnemyImage(this Enemy enemy)
        {
            switch (enemy.EnemyModel)
            {
                case EnemyCharacter.KoolAid:
                    return Properties.Resources.enemy_koolaid;
                case EnemyCharacter.EnemyCheeto:
                    return Properties.Resources.enemy_cheetos;
                case EnemyCharacter.PoisonPacket:
                    return Properties.Resources.enemy_poisonpacket;
            }
            return null; // base case 
        }

        public static Image PlayerImage(this Player player)
        {
            switch (player.PlayerModel)
            {
                case PlayerCharacter.Jenny:
                    return Properties.Resources.jenny_nobg;
                case PlayerCharacter.Jimmy:
                    return Properties.Resources.jimmy_nobg;
                case PlayerCharacter.Johnny:
                    return Properties.Resources.johnny_nobg;
            }
            return Properties.Resources.johnny_nobg; // base case
        }

        public static Image ItemImage(this Item item)
        {
            switch (item.ItemModel)
            {
                case ItemType.Arrow:
                    return Properties.Resources.arrow;
                case ItemType.Bow:
                    return Properties.Resources.bow;
                case ItemType.HealingPotion:
                    return Properties.Resources.health_potion;
                case ItemType.Key:
                    return Properties.Resources.key_removebg_preview;
            }
            return Properties.Resources.health_potion;
        }
    }
}