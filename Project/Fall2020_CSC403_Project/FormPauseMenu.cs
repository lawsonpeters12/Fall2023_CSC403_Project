using Fall2020_CSC403_Project.code;
using System;

using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormPauseMenu : FrmLevelBase
    {
        Player Player;
        
        public FormPauseMenu(Player player)
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            Player = player;
        }

        // Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Resume button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        // Restart button
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // displays the save menu
        private void button4_Click(object sender, EventArgs e)
        {
            FormSaveMenu saveMenu = new FormSaveMenu(Player);
            saveMenu.Show();
        }

        // displays the load menu
        private void button5_Click(object sender, EventArgs e)
        {
            FormLoadMenu loadMenu = new FormLoadMenu();
            loadMenu.Show();
        }
    }
}
