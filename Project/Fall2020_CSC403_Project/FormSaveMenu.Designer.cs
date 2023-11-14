namespace Fall2020_CSC403_Project
{
    partial class FormSaveMenu
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
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.save1);
            this.flowLayoutPanel1.Controls.Add(this.save2);
            this.flowLayoutPanel1.Controls.Add(this.save3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 209);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(2, 2);
            this.save1.Margin = new System.Windows.Forms.Padding(2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(163, 61);
            this.save1.TabIndex = 1;
            this.save1.Text = "Save Slot 1";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(2, 67);
            this.save2.Margin = new System.Windows.Forms.Padding(2);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(163, 66);
            this.save2.TabIndex = 3;
            this.save2.Text = "Save Slot 2";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(2, 137);
            this.save3.Margin = new System.Windows.Forms.Padding(2);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(163, 69);
            this.save3.TabIndex = 0;
            this.save3.Text = "Save Slot 3";
            this.save3.UseVisualStyleBackColor = true;
            this.save3.Click += new System.EventHandler(this.save3_Click);
            // 
            // FormSaveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.backgroundBricks;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSaveMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSaveMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
    }
}