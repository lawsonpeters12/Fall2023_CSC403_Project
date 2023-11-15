using Fall2020_CSC403_Project.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormTitleScreen : Form
    {
        public SoundPlayer TitleMusic;
        public FormTitleScreen()
        {
            InitializeComponent();
            button_newgame.Click += button_newgame_Click;
            button_loadgame.Click += button_loadgame_Click;
            this.WindowState = FormWindowState.Maximized;

            TitleMusic = new SoundPlayer(Resources.titlescreen_2);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Start playing the music for level one
            TitleMusic.PlayLooping();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop playing the music for level one
            TitleMusic.Stop();
        }

        private void button_newgame_Click(object sender, EventArgs e)
        {
            FormCharacterSelect cs = new FormCharacterSelect();
            cs.Show();
            this.Hide();
        }

        private void button_loadgame_Click(object sender, EventArgs e)
        {
            FormLoadMenu loadMenu = new FormLoadMenu();
            loadMenu.Show();
            Hide();
        }
    }
}
