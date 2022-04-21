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
            this.ExportSchedule = new System.Windows.Forms.Button();
            this.newScheduleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.legendButton = new FontAwesome.Sharp.IconButton();
            this.alertButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportSchedule
            // 
            this.ExportSchedule.AutoSize = true;
            this.ExportSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSchedule.Location = new System.Drawing.Point(298, 26);
            this.ExportSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportSchedule.Name = "ExportSchedule";
            this.ExportSchedule.Size = new System.Drawing.Size(118, 42);
            this.ExportSchedule.TabIndex = 19;
            this.ExportSchedule.Text = "Export CSV";
            this.ExportSchedule.UseVisualStyleBackColor = true;
            this.ExportSchedule.Click += new System.EventHandler(this.ExportSchedule_Click);
            // 
            // newScheduleButton
            // 
            this.newScheduleButton.AutoSize = true;
            this.newScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScheduleButton.Location = new System.Drawing.Point(435, 26);
            this.newScheduleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newScheduleButton.Name = "newScheduleButton";
            this.newScheduleButton.Size = new System.Drawing.Size(122, 42);
            this.newScheduleButton.TabIndex = 20;
            this.newScheduleButton.Text = "Generate New";
            this.newScheduleButton.UseVisualStyleBackColor = true;
            this.newScheduleButton.Click += new System.EventHandler(this.generateSchedule_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.legendButton);
            this.panel1.Controls.Add(this.alertButton);
            this.panel1.Controls.Add(this.newScheduleButton);
            this.panel1.Controls.Add(this.ExportSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 84);
            this.panel1.TabIndex = 21;
            // 
            // legendButton
            // 
            this.legendButton.FlatAppearance.BorderSize = 0;
            this.legendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.legendButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.legendButton.IconColor = System.Drawing.Color.Black;
            this.legendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.legendButton.IconSize = 30;
            this.legendButton.Location = new System.Drawing.Point(561, 33);
            this.legendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.legendButton.Name = "legendButton";
            this.legendButton.Size = new System.Drawing.Size(45, 30);
            this.legendButton.TabIndex = 22;
            this.legendButton.UseVisualStyleBackColor = true;
            // 
            // alertButton
            // 
            this.alertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alertButton.FlatAppearance.BorderSize = 0;
            this.alertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertButton.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.alertButton.IconColor = System.Drawing.Color.IndianRed;
            this.alertButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.alertButton.IconSize = 55;
            this.alertButton.Location = new System.Drawing.Point(712, 26);
            this.alertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alertButton.Name = "alertButton";
            this.alertButton.Size = new System.Drawing.Size(70, 42);
            this.alertButton.TabIndex = 21;
            this.alertButton.UseVisualStyleBackColor = true;
            // 
            // scheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "scheduleView";
            this.Size = new System.Drawing.Size(806, 640);
            this.Load += new System.EventHandler(this.scheduleView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExportSchedule;
        private System.Windows.Forms.Button newScheduleButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton alertButton;
        private FontAwesome.Sharp.IconButton legendButton;
    }
}
