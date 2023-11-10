using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel3 : FrmLevelBase
    {
        public static Vector2 bottomDoorSpawn = new Vector2(1185, 634);
        public FrmLevel3(Player player) : base(player, "level3")
        {
            InitializeComponent();
        }

        public void FrmLevel3_Load(object sender, EventArgs e)
        {
            
        }

        private void picWall1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}