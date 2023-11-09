using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fall2020_CSC403_Project
{
    public partial class FormInventory : Form
    {
        private Player player;
        private String Character;
        private int numPotions;
        private Image picJohnny = Properties.Resources.johnny_nobg;
        private Image picJimmy = Properties.Resources.jimmy_nobg;
        private Image picJenny = Properties.Resources.jenny_nobg;

        public FormInventory(string ChosenCharacter)
        {
            InitializeComponent();
            Character = ChosenCharacter;
            player = Game.player;
            numPotions = 0;

            
        }
        //method to add item to player inventory 
        
        //method to close inventory 
        private void exit_button_click(object sender, EventArgs e)
        {
            Close();
        }

        private void use_health_potion(object sender, EventArgs e)
        {
            while (numPotions > 0)
            {
                if (player.Health < player.MaxHealth)
                {
                    player.Health += 10;
                }
                else
                {
                    break;
                }
                numPotions--;
            }
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


            // labels
            lblCharacterTxt.Width = 100;
            lblCharacterTxt.Height = 25;
            lblCharacterTxt.Text = Character;

            lblHealthTxt.Width = 100;
            lblHealthTxt.Height = 25;
            lblHealthTxt.Text = "Health";

            lblExpTxt.Width = 100;
            lblExpTxt.Height = 25;
            lblExpTxt.Text = "Experience";

            lblPotionsTxt.Width = 100;
            lblPotionsTxt.Height = 25;
            lblPotionsTxt.Text = "Potions";





        }

    private void lblPlayerHealth_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
