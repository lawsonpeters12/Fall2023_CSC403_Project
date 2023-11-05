using System.ComponentModel;

namespace Fall2020_CSC403_Project
{
    partial class FrmLevel9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.doorToLvl8 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picBoss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall0
            // 
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.Location = new System.Drawing.Point(-54, -40);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(2064, 126);
            this.picWall0.TabIndex = 0;
            this.picWall0.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.Location = new System.Drawing.Point(-457, 978);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(1277, 126);
            this.picWall2.TabIndex = 1;
            this.picWall2.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.Location = new System.Drawing.Point(-40, 83);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(148, 901);
            this.picWall3.TabIndex = 2;
            this.picWall3.TabStop = false;
            // 
            // picPlayer0
            // 
            this.picPlayer0.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer0.Location = new System.Drawing.Point(910, 832);
            this.picPlayer0.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(72, 130);
            this.picPlayer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer0.TabIndex = 4;
            this.picPlayer0.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.Location = new System.Drawing.Point(1784, 83);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(161, 901);
            this.picWall1.TabIndex = 18;
            this.picWall1.TabStop = false;
            // 
            // doorToLvl8
            // 
            this.doorToLvl8.BackColor = System.Drawing.Color.Fuchsia;
            this.doorToLvl8.Location = new System.Drawing.Point(819, 978);
            this.doorToLvl8.Name = "doorToLvl8";
            this.doorToLvl8.Size = new System.Drawing.Size(251, 165);
            this.doorToLvl8.TabIndex = 24;
            this.doorToLvl8.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.Location = new System.Drawing.Point(1071, 978);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(984, 126);
            this.picWall4.TabIndex = 25;
            this.picWall4.TabStop = false;
            // 
            // picBoss
            // 
            this.picBoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.picBoss.Location = new System.Drawing.Point(795, 117);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(309, 403);
            this.picBoss.TabIndex = 26;
            this.picBoss.TabStop = false;
            // 
            // FrmLevel9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.picBoss);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.doorToLvl8);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picPlayer0);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall0);
            this.Name = "FrmLevel9";
            this.Text = "FrmLevel7";
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picPlayer0;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox doorToLvl8;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picBoss;
    }
}