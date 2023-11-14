using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
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
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            player = new Player(FrmLevel.frontDoorSpawn, 7, PlayerCharacter.Johnny, new List<string>(), new List<string>());
        }
    
        // Sets the player's Character as Johnny
        // TODO Create levelName enum
        private void buttonJohnny_Click(object sender, EventArgs e)
        {
            CreatePlayer(PlayerCharacter.Johnny, "level1");
        }

        // Sets the player's Character as Jimmy
        private void buttonJimmy_Click(object sender, EventArgs e)
        {
            CreatePlayer(PlayerCharacter.Jimmy, "level1");
        }

        // Sets the player's Character as Jenny
        private void buttonJenny_Click(object sender, EventArgs e)
        {
            CreatePlayer(PlayerCharacter.Jenny, "level1");
        }
        
        // loads the new player into level 1
        private void CreatePlayer(PlayerCharacter playerCharacter, string levelName)
        {
            player.PlayerModel = playerCharacter;
            FrmLevelBase level = new FrmLevel(player);
            level.Show();
            Hide();
        }

        private void FormCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
