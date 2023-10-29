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

namespace Fall2020_CSC403_Project
{
    public partial class FormCharacterSelect : Form
    {
        private FrmLevel level;
        public FormCharacterSelect()
        {
            InitializeComponent();
            buttonPeter.Click += buttonPeter_Click;
            buttonSponge.Click += buttonSponge_Click;
            buttonWormy.Click += buttonWormy_Click;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
        }
    
        // Sets the player's Character as Peter and starts the game.
        private void buttonPeter_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("Peter");
            this.Hide();
            level.Show();
        }

        // Sets the player's Character as The Sponge and starts the game
        private void buttonSponge_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("The Sponge");
            this.Hide();
            level.Show();
        }

        // Sets the player's Character as Wormy and starts the game
        private void buttonWormy_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("Wormy");
            this.Hide();
            level.Show();
        }

        private void FormCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
