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
        private FrmLevel LevelForm;
        private FrmBattle(String ChosenCharacter, FrmLevel l)
        {
            InitializeComponent();
            player = Game.player;
            Character = ChosenCharacter;
            LevelForm = l;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Sets the player's image based on their chosen Character.
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

        public static FrmBattle GetInstance(Enemy enemy, String ChosenCharacter, FrmLevel LevelForm)
        {
            if (instance == null)
            {
                instance = new FrmBattle(ChosenCharacter, LevelForm);
                instance.enemy = enemy;
                instance.Setup();

            }
            return instance;
        }

        // keeps experience bar within GUI element
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
                lose_screen = new FormLoseScreen(LevelForm);
                lose_screen.Show();
                lose_screen.FormBorderStyle = FormBorderStyle.None;
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
