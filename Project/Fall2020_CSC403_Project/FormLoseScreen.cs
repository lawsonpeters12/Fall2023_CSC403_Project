using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormLoseScreen : FrmLevelBase
    {
        private FrmLevelBase LevelForm;
        public FormLoseScreen()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }
        
        //method close app on clicking exit game button
        private void exit_button_click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        // Opens the load menu
        private void button1_Click(object sender, EventArgs e)
        {
            FormLoadMenu loadMenu = new FormLoadMenu();
            loadMenu.Show();
            Hide();
        }
    }
}
