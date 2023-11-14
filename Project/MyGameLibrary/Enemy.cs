using System.Drawing;
using Fall2020_CSC403_Project.code;
using System.Collections.Generic;

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
        /// <summary>
        /// This is a flag for if the enemy is defeated
        /// </summary>
        
        public string Name { get; }
        public EnemyCharacter EnemyModel { get; }
        public Size Size => SetEnemySize(EnemyModel);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, EnemyCharacter enemyModel, int level, string name) : base(initPos, new Collider(new Rectangle(new Point((int)initPos.x, (int)initPos.y), SetEnemySize(enemyModel))), level)
        {
            Name = name;
            EnemyModel = enemyModel;
        }

        public bool IsDefeated(Player player)
        {
            return player.DefeatedEnemies.Contains(Name);
        }
        
        private static Size SetEnemySize(EnemyCharacter enemyModel)
        {
            switch (enemyModel)
            {
                case EnemyCharacter.EnemyCheeto:
                    return new Size(64, 125);
                case EnemyCharacter.KoolAid:
                    return new Size(200, 160);
                case EnemyCharacter.Ghost:
                    return new Size(150, 150);
                case EnemyCharacter.Boss:
                    return new Size(300, 350);
                case EnemyCharacter.Rat:
                    return new Size(104, 128);
            }
            return new Size(80, 80);
        }
    }

    public enum EnemyCharacter
    {
        KoolAid,
        Ghost,
        EnemyCheeto,
        Boss,
        Rat
    }
}
