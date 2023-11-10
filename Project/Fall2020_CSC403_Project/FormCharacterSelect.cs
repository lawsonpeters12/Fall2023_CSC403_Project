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
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            player = new Player(FrmLevel.frontDoorSpawn, 7, PlayerCharacter.Johnny, new List<string>());
        }
    
        // Sets the player's Character as Peter and starts the game.
        // TODO Create levelName enum
        private void buttonJohnny_Click(object sender, EventArgs e)
        {
            // player.PlayerModel = PlayerCharacter.Johnny;
            // level = new FrmLevel(player);
            // level.Show();
            // Hide();
            CreatePlayer(PlayerCharacter.Johnny, "level1");
        }

        // Sets the player's Character as The Sponge and starts the game
        private void buttonJimmy_Click(object sender, EventArgs e)
        {
            // player.PlayerModel = PlayerCharacter.Jimmy;
            // level = new FrmLevel(player);
            // level.Show();
            // Hide();
            CreatePlayer(PlayerCharacter.Jimmy, "level1");
        }

        // Sets the player's Character as Wormy and starts the game
        private void buttonJenny_Click(object sender, EventArgs e)
        {
            // player.PlayerModel = PlayerCharacter.Jenny;
            // level = new FrmLevel(player);
            // level.Show();
            // Hide();
            CreatePlayer(PlayerCharacter.Jenny, "level1");
        }
        // this would help with knowing which level to put the player on upon loading
        private void CreatePlayer(PlayerCharacter playerCharacter, string levelName)
        {
            player.PlayerModel = playerCharacter;
            FrmLevelBase level;
            if (levelName == "level1")
            {
                level = new FrmLevel(player);
            }
            else
            {
                level = new FrmLevel2(player);
            }
            level.Show();
            Hide();
        }

        private void FormCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
