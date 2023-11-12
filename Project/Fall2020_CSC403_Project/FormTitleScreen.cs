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
    public partial class FormTitleScreen : Form
    {
        public FormTitleScreen()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCharacterSelect cs = new FormCharacterSelect();
            cs.Show();
            this.Hide();
        }
    }
}
