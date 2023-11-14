using Fall2020_CSC403_Project.code;
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
        private FrmLevelBase LevelForm;
        public event EventHandler FightOver;
        private FrmBattle(Player player, FrmLevelBase level)
        {
            InitializeComponent();
            this.player = player;
            LevelForm = level;
            buttonShoot.Click += buttonShoot_Click;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = LevelForm.FightColor ?? Color.Chocolate;
            BackgroundImage = LevelForm.FightBackground;
            picBossBattle.Visible = false;

            if (player.items["Bow"] > 0)
            {
                buttonShoot.Visible = true;
                textBoxArrows.Visible = true;
                textBoxArrows.Text = $"Arrows Remaining : {player.items["Arrows"]}";
            }

            // Sets the player's image based on their chosen Character.
            picPlayer.Image = player.PlayerImage();
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemy.Image = enemy.EnemyImage();
            picEnemy.SizeMode = PictureBoxSizeMode.StretchImage;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;
            
            // show health
            UpdateHealthBars();
            //show experience
            UpdateExperienceBars();
            
            var delegates = instance.FightOver?.GetInvocationList() ?? new Delegate[]{};
            foreach (var d in delegates)
            {
                instance.FightOver -= d as EventHandler;
            }
        }

        public static FrmBattle GetInstance(Enemy enemy, Player player, FrmLevelBase LevelForm)
        {
            if (instance != null) return instance;
            
            instance = new FrmBattle(player, LevelForm);
            instance.enemy = enemy;
            instance.Setup();
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
            CheckHealth();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            player.OnAttack(-10);
            player.items["Arrows"]--;
            if (player.items["Arrows"] < 1)
            {
                buttonShoot.Visible = false;
                textBoxArrows.Visible = false;
            }
            textBoxArrows.Text = $"Arrows Remaining : {player.items["Arrows"]}";
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-enemy.strength);
            }

            UpdateHealthBars();
            CheckHealth();
        }

        private void CheckHealth()
        {
            if (enemy.Health <= 0)
            {
                int experienceGain = enemy.MaxHealth * 5;
                player.DefeatedEnemies.Add(enemy.Name);
                player.AddExperience(experienceGain);
                player.UpdateLevel();
                instance = null;
                FightOver?.Invoke(this, null);
                Close();
            }
            else if (player.Health <= 0)
            {
                lose_screen = new FormLoseScreen();
                lose_screen.Show();
                lose_screen.FormBorderStyle = FormBorderStyle.None;
                FightOver?.Invoke(this, null);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
