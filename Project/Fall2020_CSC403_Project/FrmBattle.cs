using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        public static FormLoseScreen lose_screen;
        private String Character;
        private FrmBattle(String ChosenCharacter)
        {
            InitializeComponent();
            player = Game.player;
            Character = ChosenCharacter;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            if (Character == "Peter")
            {
                picPlayer.Image = Properties.Resources.petah_battle;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "The Sponge")
            {
                picPlayer.Image = Properties.Resources.thesponge;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            else if (Character == "Wormy")
            {
                picPlayer.Image = Properties.Resources.wormy;
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }



            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            
            // show health
            UpdateHealthBars();

            //show experience
            UpdateExperienceBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public static FrmBattle GetInstance(Enemy enemy, String ChosenCharacter)
        {
            if (instance == null)
            {
                instance = new FrmBattle(ChosenCharacter);
                instance.enemy = enemy;
                instance.Setup();

            }
            return instance;
        }

        private void UpdateExperienceBars()
        {
            float playerExpBar = player.Experience / player.ExperienceNeeded;
            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExperience.Width = (int)(MAX_EXPBAR_WIDTH * playerExpBar);
            lblPlayerExperienceNumber.Text = $"{player.Experience} / {player.ExperienceNeeded}";
            lblPlayerLevel.Text = $"Lvl {player.Level}";
            lblEnemyLevel.Text = $"Lvl {enemy.Level}";
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-player.strength);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-enemy.strength);
            }

            UpdateHealthBars();
            if (enemy.Health <= 0)
            {
                int experienceGain = enemy.MaxHealth * 5;
                enemy.isDefeated = true;
                player.AddExperience(experienceGain);
                player.UpdateLevel();
                player.Health = player.MaxHealth;
                instance = null;
                Close();
            }
            else if (player.Health <= 0)
            {
                lose_screen = new FormLoseScreen();
                lose_screen.Show();
                Close();
            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }
    }
}
