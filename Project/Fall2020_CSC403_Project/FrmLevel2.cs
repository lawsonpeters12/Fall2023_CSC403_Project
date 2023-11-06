using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {

        public FrmLevel2(String ChosenCharacter)
        {
            InitializeComponent();
        }

        public void FrmLevel2_Load(object sender, EventArgs e)
        {
            // init player and enemy locations and walls
            // we're gonna have to hardcode the body cleanup for every enemy that i put in this room if we can't inherit frmlevel
            // gonna have to call the function anyways every time
            // default game data

        }

        private void doorToLvl3_Click(object sender, EventArgs e)
        {

        }

        private void doorToLvl1_Click(object sender, EventArgs e)
        {

        }
    }
}