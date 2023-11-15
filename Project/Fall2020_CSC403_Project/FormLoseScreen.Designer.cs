namespace Fall2020_CSC403_Project
{
    partial class FormLoseScreen
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
            this.button_newgame = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_newgame
            // 
            this.button_newgame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_newgame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_newgame.Location = new System.Drawing.Point(952, 563);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(170, 78);
            this.button_newgame.TabIndex = 0;
            this.button_newgame.Text = "New Game";
            this.button_newgame.UseVisualStyleBackColor = false;
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_button.Location = new System.Drawing.Point(683, 563);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(167, 78);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            // 
            // FormLoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Defeat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1740, 718);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.button_newgame);
            this.DoubleBuffered = true;
            this.Name = "FormLoseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Lose";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.Button exit_button;
    }
}