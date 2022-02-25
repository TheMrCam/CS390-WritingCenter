namespace WritingCenterForms
{
    partial class scheduleView
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
            this.Saturday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.Tuesday = new System.Windows.Forms.Label();
            this.ExportSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(1506, 147);
            this.Saturday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(98, 25);
            this.Saturday.TabIndex = 16;
            this.Saturday.Text = "Saturday";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(1336, 147);
            this.Friday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(72, 25);
            this.Friday.TabIndex = 15;
            this.Friday.Text = "Friday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(1120, 147);
            this.Thursday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(102, 25);
            this.Thursday.TabIndex = 14;
            this.Thursday.Text = "Thursday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(904, 147);
            this.Wednesday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(126, 25);
            this.Wednesday.TabIndex = 13;
            this.Wednesday.Text = "Wednesday";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(555, 147);
            this.Monday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(89, 25);
            this.Monday.TabIndex = 11;
            this.Monday.Text = "Monday";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(380, 147);
            this.Sunday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(85, 25);
            this.Sunday.TabIndex = 10;
            this.Sunday.Text = "Sunday";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(44, 47);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(148, 64);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1544, 47);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(148, 64);
            this.logOut.TabIndex = 18;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(718, 147);
            this.Tuesday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(95, 25);
            this.Tuesday.TabIndex = 12;
            this.Tuesday.Text = "Tuesday";
            // 
            // ExportSchedule
            // 
            this.ExportSchedule.Location = new System.Drawing.Point(596, 47);
            this.ExportSchedule.Name = "ExportSchedule";
            this.ExportSchedule.Size = new System.Drawing.Size(146, 64);
            this.ExportSchedule.TabIndex = 19;
            this.ExportSchedule.Text = "Export Schedule";
            this.ExportSchedule.UseVisualStyleBackColor = true;
            this.ExportSchedule.Click += new System.EventHandler(this.ExportSchedule_Click);
            // 
            // scheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExportSchedule);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "scheduleView";
            this.Size = new System.Drawing.Size(1760, 1231);
            this.Load += new System.EventHandler(this.scheduleView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Button ExportSchedule;
    }
}
