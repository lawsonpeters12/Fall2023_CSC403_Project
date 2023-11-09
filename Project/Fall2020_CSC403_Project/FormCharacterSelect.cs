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
        // best place to load :) actually not, THE LOAD FORM!!!
        private FrmLevel level;
        private Form[] levels;
        private Player player;
        
        public FormCharacterSelect()
        {
            InitializeComponent();
            buttonJohnny.Click += buttonJohnny_Click;
            buttonJimmy.Click += buttonJimmy_Click;
            buttonJenny.Click += buttonJenny_Click;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            player = new Player(FrmLevel.spawnPoint, 1, PlayerCharacter.Johnny);
        }
    
        // Sets the player's Character as Peter and starts the game.
        private void buttonJohnny_Click(object sender, EventArgs e)
        {
            player.PlayerModel = PlayerCharacter.Johnny;
            level = new FrmLevel(player);
            this.Hide();
            level.Show();
        }

        // Sets the player's Character as The Sponge and starts the game
        private void buttonJimmy_Click(object sender, EventArgs e)
        {
            player.PlayerModel = PlayerCharacter.Jimmy;
            level = new FrmLevel(player);
            this.Hide();
            level.Show();
        }

        // Sets the player's Character as Wormy and starts the game
        private void buttonJenny_Click(object sender, EventArgs e)
        {
            player.PlayerModel = PlayerCharacter.Jenny;
            level = new FrmLevel(player);
            this.Hide();
            level.Show();
        }

        private void FormCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
