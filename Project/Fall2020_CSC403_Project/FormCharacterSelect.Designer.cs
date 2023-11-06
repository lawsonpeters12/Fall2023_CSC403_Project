namespace Fall2020_CSC403_Project
{
    partial class FormCharacterSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonJohnny = new System.Windows.Forms.Button();
            this.buttonJimmy = new System.Windows.Forms.Button();
            this.buttonJenny = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJohnny
            // 
            this.buttonJohnny.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonJohnny.Location = new System.Drawing.Point(214, 504);
            this.buttonJohnny.Name = "buttonJohnny";
            this.buttonJohnny.Size = new System.Drawing.Size(209, 56);
            this.buttonJohnny.TabIndex = 2;
            this.buttonJohnny.Text = "Johnny";
            this.buttonJohnny.UseVisualStyleBackColor = false;
            // 
            // buttonJimmy
            // 
            this.buttonJimmy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonJimmy.Location = new System.Drawing.Point(520, 504);
            this.buttonJimmy.Name = "buttonJimmy";
            this.buttonJimmy.Size = new System.Drawing.Size(209, 56);
            this.buttonJimmy.TabIndex = 2;
            this.buttonJimmy.Text = "Jimmy";
            this.buttonJimmy.UseVisualStyleBackColor = false;
            // 
            // buttonJenny
            // 
            this.buttonJenny.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonJenny.Location = new System.Drawing.Point(821, 504);
            this.buttonJenny.Name = "buttonJenny";
            this.buttonJenny.Size = new System.Drawing.Size(209, 56);
            this.buttonJenny.TabIndex = 3;
            this.buttonJenny.Text = "Jenny";
            this.buttonJenny.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.Character_Select;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1233, 744);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 744);
            this.Controls.Add(this.buttonJenny);
            this.Controls.Add(this.buttonJimmy);
            this.Controls.Add(this.buttonJohnny);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormCharacterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCharacterSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonJohnny;
        private System.Windows.Forms.Button buttonJimmy;
        private System.Windows.Forms.Button buttonJenny;
    }
}