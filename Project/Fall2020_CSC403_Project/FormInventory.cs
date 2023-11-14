using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormInventory : Form
    {
        private Player player;
        private String Character;
        //private int numPotions;
        private Image picJohnny = Properties.Resources.johnny_nobg;
        private Image picJimmy = Properties.Resources.jimmy_nobg;
        private Image picJenny = Properties.Resources.jenny_nobg;

        public FormInventory(string ChosenCharacter)
        {
            InitializeComponent();
            Character = ChosenCharacter;
            player = Game.player;
            //numPotions = 0;

            
        }
        //method to add item to player inventory 
        
        //method to close inventory 
        private void exit_button_click(object sender, EventArgs e)
        {
            Close();
        }

        private void use_health_potion(object sender, EventArgs e)
        {
            player.Health -= 1;
            UpdateHealthBar();
            player.items["Potions"] -= 1;
            if (player.items["Potions"] == 0)
            {
                picHealthPot.Visible = false;
                useHealthPot.Visible = false;
                textBox2.Visible = false;
            }
        }
        private void ShowHealthButton(object sender, EventArgs e)
        {
            useHealthPot.Visible = true;
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            if (Character == "Johnny")
            {
                charBG.Image = picJohnny;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            if (Character == "Jimmy")
            {
                charBG.Image = picJimmy;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            if (Character == "Jenny")
            {
                charBG.Image = picJenny;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }

            if (player.items["Bow"] > 0)
            { 
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.bow;
            }

            if (player.items["Arrows"] > 0)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.arrow;
                textBox1.Visible = true;
                textBox1.Text = $"Arrows: {player.items["Arrows"]}";
            }
            if (player.items["Potions"] > 0)
            {
                picHealthPot.Visible = true;
                picHealthPot.Image = Properties.Resources.health_potion;
                picHealthPot.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Visible = true;
                textBox2.Text = $"{player.items["Potions"]}";
            }
            if (player.items["Keys"] == 1)
            {
                picKey1.Visible = true;
                picKey1.Image = Properties.Resources.key_removebg_preview;
                picKey1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


            // labels
            lblCharacterTxt.Width = 200;
            lblCharacterTxt.Height = 25;
            lblCharacterTxt.Text = $"Level {player.Level} {Character}";

            lblHealthTxt.Width = 100;
            lblHealthTxt.Height = 25;
            lblHealthTxt.Text = "Health";

            lblExpTxt.Width = 100;
            lblExpTxt.Height = 25;
            lblExpTxt.Text = "Experience";

            lblPotionsTxt.Width = 100;
            lblPotionsTxt.Height = 25;
            lblPotionsTxt.Text = "Potions";

            lblWeaponsTxt.Width = 100;
            lblWeaponsTxt.Height = 25;
            lblWeaponsTxt.Text = "Weapons";

            lblKeysTxt.Width = 100;
            lblKeysTxt.Height = 25;
            lblKeysTxt.Text = "Keys";

            // labels for player stats

            UpdateHealthBar();
            UpdateExperienceBar();


        }
        private void UpdateHealthBar()
        {
            float playerHealthPercent = player.Health / (float)player.MaxHealth;
            const int MAX_HEALTH_BAR = 226;

            lblMaxHealth.Width = MAX_HEALTH_BAR;

            lblCurrentHealth.Width = (int)(MAX_HEALTH_BAR * playerHealthPercent);
            lblCurrentHealth.Text = $"{player.Health} / {player.MaxHealth}";
        }
        private void UpdateExperienceBar()
        {
            float playerExpPercet = player.Experience / player.ExperienceNeeded;
            const int XP_NEEDED_BAR = 226;

            lblNeededXp.Width = XP_NEEDED_BAR;
            lblNeededXp.Text = $"{player.Experience} / {player.ExperienceNeeded}";

            lblCurrXp.Width = (int)(XP_NEEDED_BAR * playerExpPercet);
            lblCurrXp.Text = $"{player.Experience} / {player.ExperienceNeeded}";

        }

        private void lblPlayerHealth_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
