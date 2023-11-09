namespace Fall2020_CSC403_Project
{
    partial class FormInventory
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.charBG = new System.Windows.Forms.PictureBox();
            this.lblCharacterTxt = new System.Windows.Forms.Label();
            this.lblHealthTxt = new System.Windows.Forms.Label();
            this.lblMaxHealth = new System.Windows.Forms.Label();
            this.lblCurrentHealth = new System.Windows.Forms.Label();
            this.lblExpTxt = new System.Windows.Forms.Label();
            this.lblNeededXp = new System.Windows.Forms.Label();
            this.lblCurrXp = new System.Windows.Forms.Label();
            this.lblPotionsTxt = new System.Windows.Forms.Label();
            this.lblWeaponsTxt = new System.Windows.Forms.Label();
            this.lblKeysTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picHealthPot = new System.Windows.Forms.PictureBox();
            this.picKey1 = new System.Windows.Forms.PictureBox();
            this.useHealthPot = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealthPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(857, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.exit_button_click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.picHealthPot);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(87, 461);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(92, 57);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // charBG
            // 
            this.charBG.BackColor = System.Drawing.Color.Transparent;
            this.charBG.Location = new System.Drawing.Point(162, 81);
            this.charBG.Name = "charBG";
            this.charBG.Size = new System.Drawing.Size(222, 233);
            this.charBG.TabIndex = 2;
            this.charBG.TabStop = false;
            // 
            // lblCharacterTxt
            // 
            this.lblCharacterTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterTxt.Location = new System.Drawing.Point(156, 33);
            this.lblCharacterTxt.Name = "lblCharacterTxt";
            this.lblCharacterTxt.Size = new System.Drawing.Size(100, 23);
            this.lblCharacterTxt.TabIndex = 3;
            this.lblCharacterTxt.Text = "label1";
            // 
            // lblHealthTxt
            // 
            this.lblHealthTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthTxt.Location = new System.Drawing.Point(538, 81);
            this.lblHealthTxt.Name = "lblHealthTxt";
            this.lblHealthTxt.Size = new System.Drawing.Size(100, 23);
            this.lblHealthTxt.TabIndex = 4;
            this.lblHealthTxt.Text = "label1";
            // 
            // lblMaxHealth
            // 
            this.lblMaxHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxHealth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxHealth.Location = new System.Drawing.Point(540, 130);
            this.lblMaxHealth.Name = "lblMaxHealth";
            this.lblMaxHealth.Size = new System.Drawing.Size(100, 23);
            this.lblMaxHealth.TabIndex = 5;
            this.lblMaxHealth.Text = "label1";
            // 
            // lblCurrentHealth
            // 
            this.lblCurrentHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCurrentHealth.Location = new System.Drawing.Point(542, 130);
            this.lblCurrentHealth.Name = "lblCurrentHealth";
            this.lblCurrentHealth.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentHealth.TabIndex = 6;
            this.lblCurrentHealth.Text = "label2";
            // 
            // lblExpTxt
            // 
            this.lblExpTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblExpTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpTxt.Location = new System.Drawing.Point(540, 184);
            this.lblExpTxt.Name = "lblExpTxt";
            this.lblExpTxt.Size = new System.Drawing.Size(100, 23);
            this.lblExpTxt.TabIndex = 7;
            this.lblExpTxt.Text = "label1";
            // 
            // lblNeededXp
            // 
            this.lblNeededXp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNeededXp.Location = new System.Drawing.Point(540, 226);
            this.lblNeededXp.Name = "lblNeededXp";
            this.lblNeededXp.Size = new System.Drawing.Size(100, 23);
            this.lblNeededXp.TabIndex = 8;
            this.lblNeededXp.Text = "label1";
            // 
            // lblCurrXp
            // 
            this.lblCurrXp.BackColor = System.Drawing.Color.Green;
            this.lblCurrXp.Location = new System.Drawing.Point(542, 226);
            this.lblCurrXp.Name = "lblCurrXp";
            this.lblCurrXp.Size = new System.Drawing.Size(100, 23);
            this.lblCurrXp.TabIndex = 9;
            this.lblCurrXp.Text = "label1";
            // 
            // lblPotionsTxt
            // 
            this.lblPotionsTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblPotionsTxt.Location = new System.Drawing.Point(83, 425);
            this.lblPotionsTxt.Name = "lblPotionsTxt";
            this.lblPotionsTxt.Size = new System.Drawing.Size(100, 23);
            this.lblPotionsTxt.TabIndex = 10;
            this.lblPotionsTxt.Text = "label1";
            // 
            // lblWeaponsTxt
            // 
            this.lblWeaponsTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTxt.Location = new System.Drawing.Point(288, 425);
            this.lblWeaponsTxt.Name = "lblWeaponsTxt";
            this.lblWeaponsTxt.Size = new System.Drawing.Size(100, 23);
            this.lblWeaponsTxt.TabIndex = 11;
            this.lblWeaponsTxt.Text = "label1";
            // 
            // lblKeysTxt
            // 
            this.lblKeysTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblKeysTxt.Location = new System.Drawing.Point(608, 428);
            this.lblKeysTxt.Name = "lblKeysTxt";
            this.lblKeysTxt.Size = new System.Drawing.Size(100, 23);
            this.lblKeysTxt.TabIndex = 12;
            this.lblKeysTxt.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(389, 464);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // picHealthPot
            // 
            this.picHealthPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHealthPot.Location = new System.Drawing.Point(3, 3);
            this.picHealthPot.Name = "picHealthPot";
            this.picHealthPot.Size = new System.Drawing.Size(89, 50);
            this.picHealthPot.TabIndex = 0;
            this.picHealthPot.TabStop = false;
            this.picHealthPot.Visible = false;
            this.picHealthPot.MouseHover += new System.EventHandler(this.ShowHealthButton);
            // 
            // picKey1
            // 
            this.picKey1.BackColor = System.Drawing.Color.Transparent;
            this.picKey1.Location = new System.Drawing.Point(608, 464);
            this.picKey1.Name = "picKey1";
            this.picKey1.Size = new System.Drawing.Size(83, 50);
            this.picKey1.TabIndex = 16;
            this.picKey1.TabStop = false;
            // 
            // useHealthPot
            // 
            this.useHealthPot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.useHealthPot.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useHealthPot.Location = new System.Drawing.Point(141, 474);
            this.useHealthPot.Name = "useHealthPot";
            this.useHealthPot.Size = new System.Drawing.Size(68, 40);
            this.useHealthPot.TabIndex = 17;
            this.useHealthPot.Text = "Use";
            this.useHealthPot.UseVisualStyleBackColor = false;
            this.useHealthPot.Visible = false;
            this.useHealthPot.Click += new System.EventHandler(this.use_health_potion);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 422);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 26);
            this.textBox2.TabIndex = 18;
            this.textBox2.Visible = false;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.inventory_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 547);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.useHealthPot);
            this.Controls.Add(this.picKey1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKeysTxt);
            this.Controls.Add(this.lblWeaponsTxt);
            this.Controls.Add(this.lblPotionsTxt);
            this.Controls.Add(this.lblCurrXp);
            this.Controls.Add(this.lblNeededXp);
            this.Controls.Add(this.lblExpTxt);
            this.Controls.Add(this.lblCurrentHealth);
            this.Controls.Add(this.lblMaxHealth);
            this.Controls.Add(this.lblHealthTxt);
            this.Controls.Add(this.lblCharacterTxt);
            this.Controls.Add(this.charBG);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealthPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox charBG;
        private System.Windows.Forms.Label lblCharacterTxt;
        private System.Windows.Forms.Label lblHealthTxt;
        private System.Windows.Forms.Label lblMaxHealth;
        private System.Windows.Forms.Label lblCurrentHealth;
        private System.Windows.Forms.Label lblExpTxt;
        private System.Windows.Forms.Label lblNeededXp;
        private System.Windows.Forms.Label lblCurrXp;
        private System.Windows.Forms.Label lblPotionsTxt;
        private System.Windows.Forms.Label lblWeaponsTxt;
        private System.Windows.Forms.Label lblKeysTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picHealthPot;
        private System.Windows.Forms.PictureBox picKey1;
        private System.Windows.Forms.Button useHealthPot;
        private System.Windows.Forms.TextBox textBox2;
    }
}