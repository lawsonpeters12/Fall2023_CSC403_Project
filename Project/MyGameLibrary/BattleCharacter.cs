using System;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Experience { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; private set; }
        public int strength { get; private set; }

        public float ExperienceNeeded;


        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider, int level) : base(initPos, collider)
        {
            this.Level = level;
            ExperienceNeeded = Level * 100;
            MaxHealth = 16 + (4 * Level);
            strength = Level * 2;
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
                ExperienceNeeded = Level * 100;
                Experience = 0;
                MaxHealth += 4;
                strength += 2;
            }
        }
    }
}
