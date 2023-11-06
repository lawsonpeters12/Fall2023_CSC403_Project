using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FormCharacterSelect : Form
    {
        private FrmLevel level;
        
        public FormCharacterSelect()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("Peter");
            this.Hide();
            level.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("The Sponge");
            this.Hide();
            level.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level = new FrmLevel("Wormy");
            this.Hide();
            level.Show();

        }

        private void FormCharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
