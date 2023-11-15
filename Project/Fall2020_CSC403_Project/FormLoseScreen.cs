using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormLoseScreen : FrmLevelBase
    {
        public FormLoseScreen()
        {
            InitializeComponent();
            button_newgame.Click += button_newgame_Click;
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
        private void button_newgame_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Close();
        }
    }
}
