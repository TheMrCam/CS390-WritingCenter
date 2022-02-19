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
            this.logOut.Location = new System.Drawing.Point(872, 37);
            this.logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(85, 37);
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
            this.panel1.Location = new System.Drawing.Point(0, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 122);
            this.panel1.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.Location = new System.Drawing.Point(820, 34);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(131, 54);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // editReqButton
            // 
            this.editReqButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editReqButton.Location = new System.Drawing.Point(636, 34);
            this.editReqButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editReqButton.Name = "editReqButton";
            this.editReqButton.Size = new System.Drawing.Size(127, 54);
            this.editReqButton.TabIndex = 2;
            this.editReqButton.Text = "Edit Requests";
            this.editReqButton.UseVisualStyleBackColor = true;
            this.editReqButton.Click += new System.EventHandler(this.EditReq_Click);
            // 
            // acctButton
            // 
            this.acctButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acctButton.Location = new System.Drawing.Point(404, 34);
            this.acctButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acctButton.Name = "acctButton";
            this.acctButton.Size = new System.Drawing.Size(127, 54);
            this.acctButton.TabIndex = 1;
            this.acctButton.Text = "Manage Accounts";
            this.acctButton.UseVisualStyleBackColor = true;
            this.acctButton.Click += new System.EventHandler(this.manageAcct_Click);
            // 
            // schedButton
            // 
            this.schedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedButton.Location = new System.Drawing.Point(216, 34);
            this.schedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(127, 54);
            this.schedButton.TabIndex = 0;
            this.schedButton.Text = "Manage Schedule";
            this.schedButton.UseVisualStyleBackColor = true;
            this.schedButton.Click += new System.EventHandler(this.ManageSched_Click);
            // 
            // schedulePlacehold
            // 
            this.schedulePlacehold.Location = new System.Drawing.Point(747, 262);
            this.schedulePlacehold.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.schedulePlacehold.Name = "schedulePlacehold";
            this.schedulePlacehold.TabIndex = 3;
            // 
            // AdminLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulePlacehold);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminLand";
            this.Size = new System.Drawing.Size(1173, 788);
            this.Load += new System.EventHandler(this.AdminLand_Load);
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
