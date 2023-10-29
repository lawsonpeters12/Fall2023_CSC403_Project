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
            this.buttonPeter = new System.Windows.Forms.Button();
            this.buttonSponge = new System.Windows.Forms.Button();
            this.buttonWormy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPeter
            // 
            this.buttonPeter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPeter.Location = new System.Drawing.Point(214, 504);
            this.buttonPeter.Name = "buttonPeter";
            this.buttonPeter.Size = new System.Drawing.Size(209, 56);
            this.buttonPeter.TabIndex = 2;
            this.buttonPeter.Text = "Peter";
            this.buttonPeter.UseVisualStyleBackColor = false;
            // 
            // buttonSponge
            // 
            this.buttonSponge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSponge.Location = new System.Drawing.Point(520, 504);
            this.buttonSponge.Name = "buttonSponge";
            this.buttonSponge.Size = new System.Drawing.Size(209, 56);
            this.buttonSponge.TabIndex = 2;
            this.buttonSponge.Text = "The Sponge";
            this.buttonSponge.UseVisualStyleBackColor = false;
            // 
            // buttonWormy
            // 
            this.buttonWormy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWormy.Location = new System.Drawing.Point(821, 504);
            this.buttonWormy.Name = "buttonWormy";
            this.buttonWormy.Size = new System.Drawing.Size(209, 56);
            this.buttonWormy.TabIndex = 3;
            this.buttonWormy.Text = "Wormy";
            this.buttonWormy.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.buttonWormy);
            this.Controls.Add(this.buttonSponge);
            this.Controls.Add(this.buttonPeter);
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
        private System.Windows.Forms.Button buttonPeter;
        private System.Windows.Forms.Button buttonSponge;
        private System.Windows.Forms.Button buttonWormy;
    }
}