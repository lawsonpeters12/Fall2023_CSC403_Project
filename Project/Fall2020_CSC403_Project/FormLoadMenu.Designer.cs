namespace Fall2020_CSC403_Project
{
    partial class FormLoadMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.load1 = new System.Windows.Forms.Button();
            this.load2 = new System.Windows.Forms.Button();
            this.load3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.load1);
            this.flowLayoutPanel1.Controls.Add(this.load2);
            this.flowLayoutPanel1.Controls.Add(this.load3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 209);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // load1
            // 
            this.load1.Location = new System.Drawing.Point(2, 2);
            this.load1.Margin = new System.Windows.Forms.Padding(2);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(163, 61);
            this.load1.TabIndex = 1;
            this.load1.Text = "Load Slot 1";
            this.load1.UseVisualStyleBackColor = true;
            this.load1.Click += new System.EventHandler(this.load1_Click);
            // 
            // load2
            // 
            this.load2.Location = new System.Drawing.Point(2, 67);
            this.load2.Margin = new System.Windows.Forms.Padding(2);
            this.load2.Name = "load2";
            this.load2.Size = new System.Drawing.Size(163, 66);
            this.load2.TabIndex = 3;
            this.load2.Text = "Load Slot 2";
            this.load2.UseVisualStyleBackColor = true;
            this.load2.Click += new System.EventHandler(this.load2_Click);
            // 
            // load3
            // 
            this.load3.Location = new System.Drawing.Point(2, 137);
            this.load3.Margin = new System.Windows.Forms.Padding(2);
            this.load3.Name = "load3";
            this.load3.Size = new System.Drawing.Size(163, 69);
            this.load3.TabIndex = 0;
            this.load3.Text = "Load Slot 3";
            this.load3.UseVisualStyleBackColor = true;
            this.load3.Click += new System.EventHandler(this.load3_Click);
            // 
            // FormLoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.backgroundBricks;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLoadMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoadMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button load3;
        private System.Windows.Forms.Button load1;
        private System.Windows.Forms.Button load2;
    }
}