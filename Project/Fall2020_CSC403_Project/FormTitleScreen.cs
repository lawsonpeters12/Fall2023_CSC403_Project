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
            button1.Click += button1_Click;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormCharacterSelect cs = new FormCharacterSelect();
            cs.Show();
            this.Hide();
        }
    }
}
