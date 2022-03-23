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
            this.Tuesday = new System.Windows.Forms.Label();
            this.ExportSchedule = new System.Windows.Forms.Button();
            this.newScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.Location = new System.Drawing.Point(922, 100);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(91, 25);
            this.Saturday.TabIndex = 16;
            this.Saturday.Text = "Saturday";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.Location = new System.Drawing.Point(807, 100);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(66, 25);
            this.Friday.TabIndex = 15;
            this.Friday.Text = "Friday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.Location = new System.Drawing.Point(666, 100);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(95, 25);
            this.Thursday.TabIndex = 14;
            this.Thursday.Text = "Thursday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.Location = new System.Drawing.Point(525, 100);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(118, 25);
            this.Wednesday.TabIndex = 13;
            this.Wednesday.Text = "Wednesday";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.Location = new System.Drawing.Point(289, 102);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(83, 25);
            this.Monday.TabIndex = 11;
            this.Monday.Text = "Monday";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.Location = new System.Drawing.Point(153, 102);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(80, 25);
            this.Sunday.TabIndex = 10;
            this.Sunday.Text = "Sunday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.Location = new System.Drawing.Point(408, 100);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(89, 25);
            this.Tuesday.TabIndex = 12;
            this.Tuesday.Text = "Tuesday";
            // 
            // ExportSchedule
            // 
            this.ExportSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSchedule.Location = new System.Drawing.Point(469, 30);
            this.ExportSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportSchedule.Name = "ExportSchedule";
            this.ExportSchedule.Size = new System.Drawing.Size(130, 52);
            this.ExportSchedule.TabIndex = 19;
            this.ExportSchedule.Text = "Export CSV";
            this.ExportSchedule.UseVisualStyleBackColor = true;
            this.ExportSchedule.Click += new System.EventHandler(this.ExportSchedule_Click);
            // 
            // newScheduleButton
            // 
            this.newScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScheduleButton.Location = new System.Drawing.Point(606, 30);
            this.newScheduleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newScheduleButton.Name = "newScheduleButton";
            this.newScheduleButton.Size = new System.Drawing.Size(155, 52);
            this.newScheduleButton.TabIndex = 20;
            this.newScheduleButton.Text = "Generate New";
            this.newScheduleButton.UseVisualStyleBackColor = true;
            this.newScheduleButton.Click += new System.EventHandler(this.generateSchedule_Click);
            // 
            // scheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newScheduleButton);
            this.Controls.Add(this.ExportSchedule);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "scheduleView";
            this.Size = new System.Drawing.Size(1024, 788);
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
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Button ExportSchedule;
        private System.Windows.Forms.Button newScheduleButton;
    }
}
