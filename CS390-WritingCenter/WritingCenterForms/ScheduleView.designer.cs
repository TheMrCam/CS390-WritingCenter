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
            this.alertButton = new FontAwesome.Sharp.IconButton();
            this.legendPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportSchedule
            // 
            this.ExportSchedule.AutoSize = true;
            this.ExportSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSchedule.Location = new System.Drawing.Point(397, 32);
            this.ExportSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportSchedule.Name = "ExportSchedule";
            this.ExportSchedule.Size = new System.Drawing.Size(168, 52);
            this.ExportSchedule.TabIndex = 19;
            this.ExportSchedule.Text = "Export CSV";
            this.ExportSchedule.UseVisualStyleBackColor = true;
            this.ExportSchedule.Click += new System.EventHandler(this.ExportSchedule_Click);
            // 
            // newScheduleButton
            // 
            this.newScheduleButton.AutoSize = true;
            this.newScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScheduleButton.Location = new System.Drawing.Point(580, 32);
            this.newScheduleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newScheduleButton.Name = "newScheduleButton";
            this.newScheduleButton.Size = new System.Drawing.Size(196, 52);
            this.newScheduleButton.TabIndex = 20;
            this.newScheduleButton.Text = "Generate New";
            this.newScheduleButton.UseVisualStyleBackColor = true;
            this.newScheduleButton.Click += new System.EventHandler(this.generateSchedule_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.legendPanel);
            this.panel1.Controls.Add(this.alertButton);
            this.panel1.Controls.Add(this.newScheduleButton);
            this.panel1.Controls.Add(this.ExportSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 103);
            this.panel1.TabIndex = 21;
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
            this.alertButton.Location = new System.Drawing.Point(949, 32);
            this.alertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alertButton.Name = "alertButton";
            this.alertButton.Size = new System.Drawing.Size(93, 52);
            this.alertButton.TabIndex = 21;
            this.alertButton.UseVisualStyleBackColor = true;
            // 
            // legendPanel
            // 
            this.legendPanel.Location = new System.Drawing.Point(824, 32);
            this.legendPanel.Name = "legendPanel";
            this.legendPanel.Size = new System.Drawing.Size(200, 71);
            this.legendPanel.TabIndex = 22;
            // 
            // scheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "scheduleView";
            this.Size = new System.Drawing.Size(1075, 788);
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
        private System.Windows.Forms.Panel legendPanel;
    }
}
