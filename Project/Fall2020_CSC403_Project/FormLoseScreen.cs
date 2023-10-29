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
    public partial class FormLoseScreen : Form
    {
        private FrmLevel LevelForm;
        public FormLoseScreen(FrmLevel l)
        {
            InitializeComponent();
            LevelForm = l;
            button1.Click += button1_Click;
        }
        //method close app on clicking exit game button
        private void exit_button_click(object sender, EventArgs e)
        {

            Close();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelForm.LoadGameState(sender, e);
            this.Hide();
        }
    }
}
