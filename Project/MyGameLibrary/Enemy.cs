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
        /// <summary>
        /// This is a flag for if the enemy is defeated
        /// </summary>
        public bool isDefeated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, Collider collider, int level, bool isDefeated) : base(initPos, collider, level)
        {
            this.isDefeated = isDefeated;
        }
    }
}
