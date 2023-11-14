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
            exit_button.Click += exit_button_Click;
            this.Size = new System.Drawing.Size(1199, 618);
        }
        
        //method close app on clicking exit game button
        private void exit_button_Click(object sender, EventArgs e)
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
