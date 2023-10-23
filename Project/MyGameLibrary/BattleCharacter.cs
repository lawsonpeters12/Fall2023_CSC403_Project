using System;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Experience { get; private set; }
        public int Level { get; private set; }
        public int Health { get; set; }
        public int MaxHealth { get; private set; }
        public int strength { get; set; }

        public float ExperienceNeeded;


        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            Level = 1;
            ExperienceNeeded = Level * 100; // document
            MaxHealth = 20;
            strength = Level * 2;
            Health = MaxHealth;
        }


        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }
        public void UpdateExperience(int experienceGain) // document
        {
            Experience += experienceGain;
        }
        public void UpdateLevel() // document
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
