using Fall2020_CSC403_Project.code;
using System;

namespace Fall2020_CSC403_Project
{
    public partial class FormLoadMenu : FrmLevelBase
    {
        public FormLoadMenu()
        {
            InitializeComponent();
            load1.Click += load1_Click;
            load2.Click += load2_Click;
            load3.Click += load3_Click;
        }

        // Saves the game to whichever of the 3 save slots the player selects
        private void load1_Click(object sender, EventArgs e)
        {
            FrmLevelBase loadedLevel = LoadGame(1);
            Hide();
            loadedLevel.Show();
            
        }
        
        private void load2_Click(object sender, EventArgs e)
        {
            FrmLevelBase loadedLevel = LoadGame(2);
            Hide();
            loadedLevel.Show();
            
        }
        
        private void load3_Click(object sender, EventArgs e)
        {
            FrmLevelBase loadedLevel = LoadGame(3);
            Hide();
            loadedLevel.Show();
            
        }
       
    }
}
