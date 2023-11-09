namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.bowItem = new System.Windows.Forms.PictureBox();
            this.frontDoor = new System.Windows.Forms.PictureBox();
            this.doorToLvl4 = new System.Windows.Forms.PictureBox();
            this.doorToLvl8 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.doorToLvl2 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(47, 55);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(79, 29);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picWall1.Location = new System.Drawing.Point(33, 0);
            this.picWall1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(1047, 158);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall0.Location = new System.Drawing.Point(-1, -68);
            this.picWall0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(158, 816);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(196, 192);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(94, 148);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            this.picEnemyPoisonPacket.Click += new System.EventHandler(this.picEnemyPoisonPacket_Click);
            // 
            // bowItem
            // 
            this.bowItem.Image = global::Fall2020_CSC403_Project.Properties.Resources.bow;
            this.bowItem.Location = new System.Drawing.Point(208, 222);
            this.bowItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bowItem.Name = "bowItem";
            this.bowItem.Size = new System.Drawing.Size(72, 78);
            this.bowItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowItem.TabIndex = 28;
            this.bowItem.TabStop = false;
            this.bowItem.Visible = false;
            // 
            // frontDoor
            // 
            this.frontDoor.BackColor = System.Drawing.Color.Red;
            this.frontDoor.Location = new System.Drawing.Point(1015, 1151);
            this.frontDoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frontDoor.Name = "frontDoor";
            this.frontDoor.Size = new System.Drawing.Size(302, 146);
            this.frontDoor.TabIndex = 24;
            this.frontDoor.TabStop = false;
            // 
            // doorToLvl4
            // 
            this.doorToLvl4.BackColor = System.Drawing.Color.Silver;
            this.doorToLvl4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway2;
            this.doorToLvl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorToLvl4.Location = new System.Drawing.Point(-15, 735);
            this.doorToLvl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doorToLvl4.Name = "doorToLvl4";
            this.doorToLvl4.Size = new System.Drawing.Size(171, 221);
            this.doorToLvl4.TabIndex = 23;
            this.doorToLvl4.TabStop = false;
            this.doorToLvl4.Click += new System.EventHandler(this.doorToLvl4_Click);
            // 
            // doorToLvl8
            // 
            this.doorToLvl8.BackColor = System.Drawing.Color.Gray;
            this.doorToLvl8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway;
            this.doorToLvl8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorToLvl8.Location = new System.Drawing.Point(1078, 0);
            this.doorToLvl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doorToLvl8.Name = "doorToLvl8";
            this.doorToLvl8.Size = new System.Drawing.Size(212, 158);
            this.doorToLvl8.TabIndex = 22;
            this.doorToLvl8.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall1;
            this.picWall9.Location = new System.Drawing.Point(1282, 0);
            this.picWall9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(895, 158);
            this.picWall9.TabIndex = 21;
            this.picWall9.TabStop = false;
            this.picWall9.Click += new System.EventHandler(this.picWall10_Click);
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall10.BackgroundImage")));
            this.picWall10.Location = new System.Drawing.Point(2020, 972);
            this.picWall10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(157, 324);
            this.picWall10.TabIndex = 20;
            this.picWall10.TabStop = false;
            // 
            // doorToLvl2
            // 
            this.doorToLvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doorToLvl2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.archway4;
            this.doorToLvl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorToLvl2.Location = new System.Drawing.Point(2020, 735);
            this.doorToLvl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doorToLvl2.Name = "doorToLvl2";
            this.doorToLvl2.Size = new System.Drawing.Size(157, 244);
            this.doorToLvl2.TabIndex = 18;
            this.doorToLvl2.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(508, 316);
            this.picWall2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(100, 390);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall7.BackgroundImage")));
            this.picWall7.Location = new System.Drawing.Point(2020, 31);
            this.picWall7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(157, 718);
            this.picWall7.TabIndex = 15;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall3;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1352, 541);
            this.picWall8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(673, 92);
            this.picWall8.TabIndex = 10;
            this.picWall8.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall6.Location = new System.Drawing.Point(508, 1150);
            this.picWall6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(506, 147);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.separatewall2;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(146, 620);
            this.picWall11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(469, 106);
            this.picWall11.TabIndex = 8;
            this.picWall11.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall3;
            this.picWall4.Location = new System.Drawing.Point(-1, 948);
            this.picWall4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(158, 322);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall5.Location = new System.Drawing.Point(-45, 1150);
            this.picWall5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(581, 147);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(1446, 300);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(96, 165);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1681, 130);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(290, 298);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(1091, 937);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(81, 174);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(181, 760);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1912, 771);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1137, 168);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 162);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall4;
            this.picWall3.Location = new System.Drawing.Point(1312, 1151);
            this.picWall3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(829, 146);
            this.picWall3.TabIndex = 33;
            this.picWall3.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.floor;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.bowItem);
            this.Controls.Add(this.frontDoor);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.doorToLvl2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.doorToLvl8);
            this.Controls.Add(this.doorToLvl4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBossKoolAid);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorToLvl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.PictureBox doorToLvl4;

    private System.Windows.Forms.PictureBox doorToLvl8;

    private System.Windows.Forms.PictureBox frontDoor;

    //private System.Windows.Forms.PictureBox picWall3;

    private System.Windows.Forms.PictureBox doorToLvl2;

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall11;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox bowItem;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.PictureBox picWall3;
    }
}

