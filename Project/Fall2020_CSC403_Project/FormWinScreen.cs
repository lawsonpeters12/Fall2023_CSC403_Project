using System;using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FormWinScreen : Form
    {
        FrmLevel LevelForm;

        public SoundPlayer WinMusic; 

        public FormWinScreen(FrmLevel l)
        {
            InitializeComponent();

            WinMusic = new SoundPlayer(Resources.winmusic);

            button1.Click += load_button_click;
            button2.Click += exit_button_click;
            LevelForm = l;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            WinMusic.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            WinMusic.Stop();
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
