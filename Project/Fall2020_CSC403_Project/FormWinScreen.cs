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
    public partial class FormWinScreen : Form
    {
        public FormWinScreen()
        {
            InitializeComponent();
        }

        private void exit_button_click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
