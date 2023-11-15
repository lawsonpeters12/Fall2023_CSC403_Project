namespace Fall2020_CSC403_Project
{
    partial class FormTitleScreen
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
            this.button_loadgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_newgame
            // 
            this.button_newgame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_newgame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_newgame.Location = new System.Drawing.Point(693, 845);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(194, 75);
            this.button_newgame.TabIndex = 0;
            this.button_newgame.Text = "New Game";
            this.button_newgame.UseVisualStyleBackColor = false;
            // 
            // button_loadgame
            // 
            this.button_loadgame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_loadgame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_loadgame.Location = new System.Drawing.Point(1002, 845);
            this.button_loadgame.Name = "button_loadgame";
            this.button_loadgame.Size = new System.Drawing.Size(194, 75);
            this.button_loadgame.TabIndex = 1;
            this.button_loadgame.Text = "Load Game";
            this.button_loadgame.UseVisualStyleBackColor = false;
            // 
            // FormTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.TitleScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.button_loadgame);
            this.Controls.Add(this.button_newgame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTitleScreen";
            this.Text = "FormTitleScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.Button button_loadgame;
    }
}