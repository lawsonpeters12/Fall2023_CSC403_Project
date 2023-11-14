using System;
using System.Drawing;
using System.IO;

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
            returnButton.Click += returnButton_Click;
        }

        // Loads the game from whichever of the 3 save slots the player selects, if they exist
        private void load1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("save1.json"))
            {
                load1.BackColor = Color.Gray;
                return;
            }
            FrmLevelBase loadedLevel = LoadGame(1);
            Hide();
            loadedLevel.Show();
        }
        
        private void load2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("save2.json"))
            {
                load2.BackColor = Color.Gray;
                return;
            }
            FrmLevelBase loadedLevel = LoadGame(2);
            Hide();
            loadedLevel.Show();
        }
        
        private void load3_Click(object sender, EventArgs e)
        {
            if (!File.Exists("save3.json"))
            {
                load3.BackColor = Color.Gray;
                return;
            }
            FrmLevelBase loadedLevel = LoadGame(3);
            Hide();
            loadedLevel.Show();
        }

        // closes the load menu
        private void returnButton_Click(object sender, EventArgs e)
        {
            Hide(); 
        }
    }
}
