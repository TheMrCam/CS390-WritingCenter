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
            this.newScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(753, 76);
            this.Saturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(49, 13);
            this.Saturday.TabIndex = 16;
            this.Saturday.Text = "Saturday";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(668, 76);
            this.Friday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(35, 13);
            this.Friday.TabIndex = 15;
            this.Friday.Text = "Friday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(560, 76);
            this.Thursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(51, 13);
            this.Thursday.TabIndex = 14;
            this.Thursday.Text = "Thursday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(452, 76);
            this.Wednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(64, 13);
            this.Wednesday.TabIndex = 13;
            this.Wednesday.Text = "Wednesday";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(278, 76);
            this.Monday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(45, 13);
            this.Monday.TabIndex = 11;
            this.Monday.Text = "Monday";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(190, 76);
            this.Sunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(43, 13);
            this.Sunday.TabIndex = 10;
            this.Sunday.Text = "Sunday";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(22, 24);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 33);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(772, 24);
            this.logOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(88, 33);
            this.logOut.TabIndex = 18;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(359, 76);
            this.Tuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(48, 13);
            this.Tuesday.TabIndex = 12;
            this.Tuesday.Text = "Tuesday";
            // 
            // ExportSchedule
            // 
            this.ExportSchedule.Location = new System.Drawing.Point(265, 24);
            this.ExportSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportSchedule.Name = "ExportSchedule";
            this.ExportSchedule.Size = new System.Drawing.Size(88, 33);
            this.ExportSchedule.TabIndex = 19;
            this.ExportSchedule.Text = "Export CSV";
            this.ExportSchedule.UseVisualStyleBackColor = true;
            this.ExportSchedule.Click += new System.EventHandler(this.ExportSchedule_Click);
            // 
            // newScheduleButton
            // 
            this.newScheduleButton.Location = new System.Drawing.Point(523, 24);
            this.newScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.newScheduleButton.Name = "newScheduleButton";
            this.newScheduleButton.Size = new System.Drawing.Size(88, 33);
            this.newScheduleButton.TabIndex = 20;
            this.newScheduleButton.Text = "Generate New";
            this.newScheduleButton.UseVisualStyleBackColor = true;
            this.newScheduleButton.Click += new System.EventHandler(this.generateSchedule_Click);
            // 
            // scheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newScheduleButton);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "scheduleView";
            this.Size = new System.Drawing.Size(880, 640);
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
        private System.Windows.Forms.Button newScheduleButton;
    }
}
