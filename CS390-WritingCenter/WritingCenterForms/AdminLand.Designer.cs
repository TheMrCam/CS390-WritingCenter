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
            this.settingsButton = new System.Windows.Forms.Button();
            this.editReqButton = new System.Windows.Forms.Button();
            this.acctButton = new System.Windows.Forms.Button();
            this.schedButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1022, 38);
            this.logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(85, 37);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.Location = new System.Drawing.Point(710, 32);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.editReqButton.Location = new System.Drawing.Point(507, 32);
            this.editReqButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.acctButton.Location = new System.Drawing.Point(286, 32);
            this.acctButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.schedButton.Location = new System.Drawing.Point(69, 32);
            this.schedButton.Margin = new System.Windows.Forms.Padding(4);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(127, 54);
            this.schedButton.TabIndex = 0;
            this.schedButton.Text = "Manage Schedule";
            this.schedButton.UseVisualStyleBackColor = true;
            this.schedButton.Click += new System.EventHandler(this.ManageSched_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.schedButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.acctButton);
            this.panel1.Controls.Add(this.editReqButton);
            this.panel1.Location = new System.Drawing.Point(275, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 120);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WritingCenterForms.Properties.Resources.CWC_logo_Black_Secondary;
            this.pictureBox1.Location = new System.Drawing.Point(14, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 726);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLand";
            this.Size = new System.Drawing.Size(1160, 788);
            this.Load += new System.EventHandler(this.AdminLand_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button editReqButton;
        private System.Windows.Forms.Button acctButton;
        private System.Windows.Forms.Button schedButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
