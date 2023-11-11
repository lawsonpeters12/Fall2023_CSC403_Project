namespace Fall2020_CSC403_Project 
{
    partial class FrmBattle 
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerExperience = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerExperienceNumber = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblEnemyLevel = new System.Windows.Forms.Label();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.textBoxArrows = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(105, 748);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(192, 66);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(107, 606);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(339, 31);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(105, 605);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(775, 604);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 35);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(776, 605);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(339, 31);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // lblPlayerExperience
            // 
            this.lblPlayerExperience.BackColor = System.Drawing.Color.SpringGreen;
            this.lblPlayerExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerExperience.ForeColor = System.Drawing.Color.White;
            this.lblPlayerExperience.Location = new System.Drawing.Point(107, 665);
            this.lblPlayerExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerExperience.Name = "lblPlayerExperience";
            this.lblPlayerExperience.Size = new System.Drawing.Size(339, 31);
            this.lblPlayerExperience.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(105, 665);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 35);
            this.label4.TabIndex = 10;
            // 
            // lblPlayerExperienceNumber
            // 
            this.lblPlayerExperienceNumber.AutoSize = true;
            this.lblPlayerExperienceNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerExperienceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerExperienceNumber.ForeColor = System.Drawing.Color.White;
            this.lblPlayerExperienceNumber.Location = new System.Drawing.Point(107, 668);
            this.lblPlayerExperienceNumber.Name = "lblPlayerExperienceNumber";
            this.lblPlayerExperienceNumber.Size = new System.Drawing.Size(316, 29);
            this.lblPlayerExperienceNumber.TabIndex = 11;
            this.lblPlayerExperienceNumber.Text = "lblPlayerExperienceNumber";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.ForeColor = System.Drawing.Color.White;
            this.lblPlayerLevel.Location = new System.Drawing.Point(456, 665);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(165, 29);
            this.lblPlayerLevel.TabIndex = 12;
            this.lblPlayerLevel.Text = "lblPlayerLevel";
            // 
            // lblEnemyLevel
            // 
            this.lblEnemyLevel.AutoSize = true;
            this.lblEnemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyLevel.ForeColor = System.Drawing.Color.White;
            this.lblEnemyLevel.Location = new System.Drawing.Point(1123, 606);
            this.lblEnemyLevel.Name = "lblEnemyLevel";
            this.lblEnemyLevel.Size = new System.Drawing.Size(171, 29);
            this.lblEnemyLevel.TabIndex = 13;
            this.lblEnemyLevel.Text = "lblEnemyLevel";
            // 
            // picHeart
            // 
            this.picHeart.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.HeartImage;
            this.picHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHeart.Location = new System.Drawing.Point(50, 605);
            this.picHeart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(50, 35);
            this.picHeart.TabIndex = 14;
            this.picHeart.TabStop = false;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1170, 866);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(45, 42);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(773, 151);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(342, 409);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.HeartImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(719, 604);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 35);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(64, 668);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 28);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "XP";
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(145, 151);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(342, 409);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 17;
            this.picPlayer.TabStop = false;
            // 
            // buttonShoot
            // 
            this.buttonShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoot.Location = new System.Drawing.Point(358, 748);
            this.buttonShoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(192, 66);
            this.buttonShoot.TabIndex = 18;
            this.buttonShoot.Text = "Shoot Arrow";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Visible = false;
            this.buttonShoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxArrows
            // 
            this.textBoxArrows.Location = new System.Drawing.Point(358, 714);
            this.textBoxArrows.Name = "textBoxArrows";
            this.textBoxArrows.Size = new System.Drawing.Size(192, 26);
            this.textBoxArrows.TabIndex = 19;
            this.textBoxArrows.Visible = false;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 928);
            this.Controls.Add(this.textBoxArrows);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.lblEnemyLevel);
            this.Controls.Add(this.lblPlayerLevel);
            this.Controls.Add(this.lblPlayerExperienceNumber);
            this.Controls.Add(this.lblPlayerExperience);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight!";
            this.Load += new System.EventHandler(this.FrmBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnemyHealthFull;
        private System.Windows.Forms.PictureBox picBossBattle;
        private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Label lblPlayerExperience;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerExperienceNumber;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblEnemyLevel;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.TextBox textBoxArrows;
    }
}