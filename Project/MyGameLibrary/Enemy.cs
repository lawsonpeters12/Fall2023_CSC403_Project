using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter
    {
        /// <summary>
        /// This is the image for an enemy
        /// </summary>
        public Image Img { get; set; }

        /// <summary>
        /// This is the background color for the fight form for this enemy
        /// </summary>
        public Color Color { get; set; }
        
        public string Name { get; }
        /// <summary>
        /// This is the model that the enemy uses
        /// </summary>
        public EnemyCharacter EnemyModel { get; }
        /// <summary>
        /// This is the size of the enemy
        /// </summary>
        public Size Size => SetEnemySize(EnemyModel);

        /// <summary>
        /// Enemy character constructor
        /// </summary>
        /// <param name="initPos"></param>
        /// <param name="enemyModel"></param>
        /// <param name="level"></param>
        /// <param name="name"></param>
        public Enemy(Vector2 initPos, EnemyCharacter enemyModel, int level, string name) : base(initPos, new Collider(new Rectangle(new Point((int)initPos.x, (int)initPos.y), SetEnemySize(enemyModel))), level)
        {
            Name = name;
            EnemyModel = enemyModel;
        }

        public bool IsDefeated(Player player)
        {
            return player.DefeatedEnemies.Contains(Name);
        }
        
        /// <summary>
        /// Assigns fixed size values for each type enemy
        /// </summary>
        /// <param name="enemyModel"></param>
        /// <returns>Size of the enemy type</returns>
        private static Size SetEnemySize(EnemyCharacter enemyModel)
        {
            switch (enemyModel)
            {
                case EnemyCharacter.Ghost:
                    return new Size(150, 150);
                case EnemyCharacter.Boss:
                    return new Size(350, 350);
                case EnemyCharacter.Rat:
                    return new Size(104, 128);
                case EnemyCharacter.HellHound:
                    return new Size(150, 100);
                case EnemyCharacter.HellBeast:
                    return new Size(150, 150);
                case EnemyCharacter.Slime:
                    return new Size(115, 115);
                case EnemyCharacter.BiggerSlime:
                    return new Size(200, 200);
                case EnemyCharacter.SewerCrawly:
                    return new Size(150, 150);
                case EnemyCharacter.miniBoss:
                    return new Size(200, 200);
            }
            return new Size(80, 80);
        }
    }

    public enum EnemyCharacter
    {
        Ghost,
        Boss,
        Rat,
        HellHound,
        HellBeast,
        Slime,
        BiggerSlime,
        SewerCrawly,
        miniBoss
    }
}
