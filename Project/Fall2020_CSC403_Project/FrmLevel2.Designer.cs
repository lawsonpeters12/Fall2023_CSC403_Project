using System.ComponentModel;

namespace Fall2020_CSC403_Project
{
    partial class FrmLevel2
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
            this.components = new System.ComponentModel.Container();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picDoor0 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picDoor1 = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor1)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall0
            // 
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall0.Location = new System.Drawing.Point(22, -1);
            this.picWall0.Margin = new System.Windows.Forms.Padding(2);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(1140, 101);
            this.picWall0.TabIndex = 0;
            this.picWall0.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall2.Location = new System.Drawing.Point(-19, 755);
            this.picWall2.Margin = new System.Windows.Forms.Padding(2);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(1471, 94);
            this.picWall2.TabIndex = 1;
            this.picWall2.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall3.Location = new System.Drawing.Point(-1, -1);
            this.picWall3.Margin = new System.Windows.Forms.Padding(2);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(106, 470);
            this.picWall3.TabIndex = 2;
            this.picWall3.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall2;
            this.picWall1.Location = new System.Drawing.Point(1351, 19);
            this.picWall1.Margin = new System.Windows.Forms.Padding(2);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(101, 814);
            this.picWall1.TabIndex = 3;
            this.picWall1.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall7.Location = new System.Drawing.Point(-1, 599);
            this.picWall7.Margin = new System.Windows.Forms.Padding(2);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(106, 234);
            this.picWall7.TabIndex = 5;
            this.picWall7.TabStop = false;
            // 
            // picDoor0
            // 
            this.picDoor0.BackColor = System.Drawing.Color.Fuchsia;
            this.picDoor0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway2;
            this.picDoor0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDoor0.Location = new System.Drawing.Point(-28, 469);
            this.picDoor0.Margin = new System.Windows.Forms.Padding(2);
            this.picDoor0.Name = "picDoor0";
            this.picDoor0.Size = new System.Drawing.Size(134, 139);
            this.picDoor0.TabIndex = 6;
            this.picDoor0.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall6.Location = new System.Drawing.Point(77, 301);
            this.picWall6.Margin = new System.Windows.Forms.Padding(2);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(628, 127);
            this.picWall6.TabIndex = 7;
            this.picWall6.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picWall5.Location = new System.Drawing.Point(896, 301);
            this.picWall5.Margin = new System.Windows.Forms.Padding(2);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(458, 127);
            this.picWall5.TabIndex = 8;
            this.picWall5.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall4.Location = new System.Drawing.Point(1284, -2);
            this.picWall4.Margin = new System.Windows.Forms.Padding(2);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(168, 102);
            this.picWall4.TabIndex = 9;
            this.picWall4.TabStop = false;
            // 
            // picDoor1
            // 
            this.picDoor1.BackColor = System.Drawing.Color.Gray;
            this.picDoor1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway;
            this.picDoor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDoor1.Location = new System.Drawing.Point(1160, -15);
            this.picDoor1.Margin = new System.Windows.Forms.Padding(2);
            this.picDoor1.Name = "picDoor1";
            this.picDoor1.Size = new System.Drawing.Size(130, 115);
            this.picDoor1.TabIndex = 10;
            this.picDoor1.TabStop = false;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // FrmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(1455, 850);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picDoor1);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picDoor0);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall5);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLevel2";
            this.Load += new System.EventHandler(this.FrmLevel2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor1)).EndInit();
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
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picDoor0;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picDoor1;
        private System.Windows.Forms.Timer tmrPlayerMove;
    }
}