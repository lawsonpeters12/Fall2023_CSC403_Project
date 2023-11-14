using Fall2020_CSC403_Project.code;
using System;

namespace Fall2020_CSC403_Project
{
    public partial class FormSaveMenu : FrmLevelBase
    {
        Player Player;
        public FormSaveMenu(Player player)
        {
            InitializeComponent();
            Player = player;
        }

        // Saves the game to whichever of the 3 save slots the player selects
        private void save1_Click(object sender, EventArgs e)
        {
            SaveGame(Player, 1);
            Hide();
        }
        
        private void save2_Click(object sender, EventArgs e)
        {
            SaveGame(Player, 2);
            Hide();
        }
        
        private void save3_Click(object sender, EventArgs e)
        {
            SaveGame(Player, 3);
            Hide();
        }
        
        // closes the save menu
        private void returnButton_Click(object sender, EventArgs e)
        {
            Hide(); 
        }
    }
}
