namespace WritingCenterForms
{
    partial class AdminLand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(509, 22);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(64, 30);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 95);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.settings_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Requests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EditReq_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Accounts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.manageAcct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ManageSched_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(346, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WritingCenterForms.Properties.Resources.Coe_College;
            this.pictureBox1.Location = new System.Drawing.Point(22, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Name = "AdminLand";
            this.Size = new System.Drawing.Size(600, 375);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
