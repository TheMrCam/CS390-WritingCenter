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
            this.settingsButton = new System.Windows.Forms.Button();
            this.editReqButton = new System.Windows.Forms.Button();
            this.acctButton = new System.Windows.Forms.Button();
            this.schedButton = new System.Windows.Forms.Button();
            this.schedulePlacehold = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(654, 30);
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
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.editReqButton);
            this.panel1.Controls.Add(this.acctButton);
            this.panel1.Controls.Add(this.schedButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 99);
            this.panel1.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.Location = new System.Drawing.Point(615, 28);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(98, 44);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // editReqButton
            // 
            this.editReqButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editReqButton.Location = new System.Drawing.Point(477, 28);
            this.editReqButton.Name = "editReqButton";
            this.editReqButton.Size = new System.Drawing.Size(95, 44);
            this.editReqButton.TabIndex = 2;
            this.editReqButton.Text = "Edit Requests";
            this.editReqButton.UseVisualStyleBackColor = true;
            this.editReqButton.Click += new System.EventHandler(this.EditReq_Click);
            // 
            // acctButton
            // 
            this.acctButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acctButton.Location = new System.Drawing.Point(303, 28);
            this.acctButton.Name = "acctButton";
            this.acctButton.Size = new System.Drawing.Size(95, 44);
            this.acctButton.TabIndex = 1;
            this.acctButton.Text = "Manage Accounts";
            this.acctButton.UseVisualStyleBackColor = true;
            this.acctButton.Click += new System.EventHandler(this.manageAcct_Click);
            // 
            // schedButton
            // 
            this.schedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedButton.Location = new System.Drawing.Point(162, 28);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(95, 44);
            this.schedButton.TabIndex = 0;
            this.schedButton.Text = "Manage Schedule";
            this.schedButton.UseVisualStyleBackColor = true;
            this.schedButton.Click += new System.EventHandler(this.ManageSched_Click);
            // 
            // schedulePlacehold
            // 
            this.schedulePlacehold.Location = new System.Drawing.Point(560, 213);
            this.schedulePlacehold.Name = "schedulePlacehold";
            this.schedulePlacehold.TabIndex = 3;
            // 
            // AdminLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulePlacehold);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Name = "AdminLand";
            this.Size = new System.Drawing.Size(880, 640);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editReqButton;
        private System.Windows.Forms.Button acctButton;
        private System.Windows.Forms.Button schedButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.MonthCalendar schedulePlacehold;
    }
}
