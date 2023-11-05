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
        private Image picPeter = Properties.Resources.petah_nobg;
        private Image picSponge = Properties.Resources.thesponge_nobg;
        private Image picWormy = Properties.Resources.wormy_nobg;

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
            if (Character == "Peter")
            {
                charBG.Image = picPeter;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            if (Character == "The Sponge")
            {
                charBG.Image = picSponge;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
            }
            if (Character == "Wormy")
            {
                charBG.Image = picWormy;
                charBG.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Invalidate();
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
    }
}
