using Fall2020_CSC403_Project.code;
using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormMap : Form
    {
        private Player player;
        string LevelName;
        public FormMap(Player player, string LevelName)
        {
            InitializeComponent();
            this.player = player;
            this.LevelName = LevelName;
            button1.Click += button1_Click;
            
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            switch (LevelName)
            {
                case "level1":
                    pictureBoxLevel1.Image = player.PlayerImage();
                    break;
                case "level2":
                    pictureBoxLevel2.Image = player.PlayerImage();
                    break;
                case "level3":
                    pictureBoxLevel3.Image = player.PlayerImage();
                    break;
                case "level4":
                    pictureBoxLevel4.Image = player.PlayerImage();
                    break;
                case "level5":
                    pictureBoxLevel5.Image = player.PlayerImage();
                    break;
                case "level6":
                    pictureBoxLevel6.Image = player.PlayerImage();
                    break;
                case "level7":
                    pictureBoxLevel7.Image = player.PlayerImage();
                    break;
                case "level8":
                    pictureBoxLevel8.Image = player.PlayerImage();
                    break;
                case "level9":
                    pictureBoxLevel9.Image = player.PlayerImage();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
