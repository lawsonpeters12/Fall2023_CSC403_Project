using System;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Experience { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth => 16 + (4 * Level);

        public int strength => Level * 2;

        public float ExperienceNeeded => Level * 100;

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider, int level) : base(initPos, collider)
        {
            Level = level;
            Health = MaxHealth;
        }


        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }
        
        public void AddExperience(int experienceGain)
        {
            Experience += experienceGain;
        }
        public void UpdateLevel()
        {
            if (Experience >= ExperienceNeeded)
            {
                Level++;
                Experience = 0;
            }
        }
    }
}
