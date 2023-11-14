using System;using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormWinScreen : Form
    {
        FrmLevel LevelForm;
        public FormWinScreen(FrmLevel l)
        {
            InitializeComponent();
            button1.Click += load_button_click;
            button2.Click += exit_button_click;
            LevelForm = l;
        }

        private void exit_button_click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        
        private void load_button_click(object sender, EventArgs e)
        {
            //LevelForm.LoadGameState(sender, e);
            Close();
        }
    }
}
