using System.ComponentModel;

namespace Fall2020_CSC403_Project
{
    partial class FrmLevel3
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
            this.doorToLvl2 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall0
            // 
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall0.Location = new System.Drawing.Point(33, -2);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(2145, 157);
            this.picWall0.TabIndex = 0;
            this.picWall0.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall2.Location = new System.Drawing.Point(33, 1166);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(1682, 145);
            this.picWall2.TabIndex = 1;
            this.picWall2.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall3.Location = new System.Drawing.Point(2, -2);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(148, 1313);
            this.picWall3.TabIndex = 2;
            this.picWall3.TabStop = false;
            // 
            // doorToLvl2
            // 
            this.doorToLvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doorToLvl2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway3;
            this.doorToLvl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorToLvl2.Location = new System.Drawing.Point(1712, 1166);
            this.doorToLvl2.Name = "doorToLvl2";
            this.doorToLvl2.Size = new System.Drawing.Size(224, 145);
            this.doorToLvl2.TabIndex = 10;
            this.doorToLvl2.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall4.Location = new System.Drawing.Point(1932, 1166);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(213, 145);
            this.picWall4.TabIndex = 11;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(1479, 457);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(98, 777);
            this.picWall5.TabIndex = 12;
            this.picWall5.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall3;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(921, 617);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(656, 98);
            this.picWall6.TabIndex = 13;
            this.picWall6.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(512, 63);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(94, 654);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall2;
            this.picWall1.Location = new System.Drawing.Point(2022, 32);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(156, 1279);
            this.picWall1.TabIndex = 3;
            this.picWall1.TabStop = false;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // FrmLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.doorToLvl2);
            this.Controls.Add(this.picWall3);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLevel3";
            this.Load += new System.EventHandler(this.FrmLevel3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox doorToLvl2;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.Timer tmrPlayerMove;
    }
}