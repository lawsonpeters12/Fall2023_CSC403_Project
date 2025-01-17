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
            this.components = new System.ComponentModel.Container();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.doorToLvl8 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall0
            // 
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall0.Location = new System.Drawing.Point(-56, -6);
            this.picWall0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(1862, 135);
            this.picWall0.TabIndex = 0;
            this.picWall0.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall2.Location = new System.Drawing.Point(57, 855);
            this.picWall2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(747, 112);
            this.picWall2.TabIndex = 1;
            this.picWall2.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall3.Location = new System.Drawing.Point(3, -6);
            this.picWall3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(116, 957);
            this.picWall3.TabIndex = 2;
            this.picWall3.TabStop = false;
            // 
            // picPlayer0
            // 
            this.picPlayer0.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer0.Location = new System.Drawing.Point(1024, 1040);
            this.picPlayer0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(81, 162);
            this.picPlayer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer0.TabIndex = 4;
            this.picPlayer0.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall2;
            this.picWall1.Location = new System.Drawing.Point(1706, -6);
            this.picWall1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(100, 957);
            this.picWall1.TabIndex = 18;
            this.picWall1.TabStop = false;
            // 
            // doorToLvl8
            // 
            this.doorToLvl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doorToLvl8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.door;
            this.doorToLvl8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorToLvl8.Location = new System.Drawing.Point(802, 827);
            this.doorToLvl8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.doorToLvl8.Name = "doorToLvl8";
            this.doorToLvl8.Size = new System.Drawing.Size(243, 140);
            this.doorToLvl8.TabIndex = 24;
            this.doorToLvl8.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall4.Location = new System.Drawing.Point(1041, 855);
            this.picWall4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(765, 112);
            this.picWall4.TabIndex = 25;
            this.picWall4.TabStop = false;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // FrmLevel9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(1798, 951);
            this.Controls.Add(this.doorToLvl8);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picPlayer0);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall0);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmLevel9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLevel9";
            this.Load += new System.EventHandler(this.FrmLevel9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picPlayer0;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox doorToLvl8;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.Timer tmrPlayerMove;
    }
}