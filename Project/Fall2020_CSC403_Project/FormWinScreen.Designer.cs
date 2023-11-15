namespace Fall2020_CSC403_Project
{
    partial class FormWinScreen
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
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_newgame
            // 
            this.button_newgame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_newgame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_newgame.Location = new System.Drawing.Point(450, 580);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(187, 75);
            this.button_newgame.TabIndex = 0;
            this.button_newgame.Text = "New Game";
            this.button_newgame.UseVisualStyleBackColor = false;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_exit.Location = new System.Drawing.Point(740, 580);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(192, 75);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.exit_button_click);
            // 
            // FormWinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.victory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1744, 724);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_newgame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWinScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Win!";
            this.Load += new System.EventHandler(this.FormWinScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.Button button_exit;
    }
}