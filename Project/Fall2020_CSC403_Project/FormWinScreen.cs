using System;
using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FormWinScreen : FrmLevelBase
    {
        public SoundPlayer WinMusic;

        public FormWinScreen()
        {
            InitializeComponent();
            WinMusic = new SoundPlayer(Resources.winmusic);
            this.Size = new System.Drawing.Size(1199, 618);
            button_newgame.Click += button_newgame_Click;
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

        private void button_newgame_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Close();
        }

        private void FormWinScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
