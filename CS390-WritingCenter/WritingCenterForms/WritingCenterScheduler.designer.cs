namespace WritingCenterForms
{
    partial class WritingCenterScheduler
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
            this.coeLogo = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.acctManagePage1 = new WritingCenterForms.AcctManagePage();
            this.adminLand1 = new WritingCenterForms.AdminLand();
            this.userLand1 = new WritingCenterForms.UserLand();
            ((System.ComponentModel.ISupportInitialize)(this.coeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // coeLogo
            // 
            this.coeLogo.Image = global::WritingCenterForms.Properties.Resources.Coe_College;
            this.coeLogo.Location = new System.Drawing.Point(190, 44);
            this.coeLogo.Margin = new System.Windows.Forms.Padding(2);
            this.coeLogo.Name = "coeLogo";
            this.coeLogo.Size = new System.Drawing.Size(227, 162);
            this.coeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coeLogo.TabIndex = 5;
            this.coeLogo.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(251, 309);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(95, 44);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logIn_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(251, 227);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(166, 20);
            this.usernameBox.TabIndex = 7;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(251, 267);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(166, 20);
            this.PasswordBox.TabIndex = 8;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(187, 230);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(187, 270);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // acctManagePage1
            // 
            this.acctManagePage1.Location = new System.Drawing.Point(0, -1);
            this.acctManagePage1.Name = "acctManagePage1";
            this.acctManagePage1.Size = new System.Drawing.Size(600, 375);
            this.acctManagePage1.TabIndex = 14;
            this.acctManagePage1.Visible = false;
            // 
            // adminLand1
            // 
            this.adminLand1.Location = new System.Drawing.Point(0, -1);
            this.adminLand1.Name = "adminLand1";
            this.adminLand1.Size = new System.Drawing.Size(600, 375);
            this.adminLand1.TabIndex = 13;
            this.adminLand1.Visible = false;
            this.adminLand1.Load += new System.EventHandler(this.adminLand1_Load);
            // 
            // userLand1
            // 
            this.userLand1.Location = new System.Drawing.Point(0, -1);
            this.userLand1.Name = "userLand1";
            this.userLand1.Size = new System.Drawing.Size(600, 375);
            this.userLand1.TabIndex = 11;
            this.userLand1.Visible = false;
            // 
            // WritingCenterScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 377);
            this.Controls.Add(this.adminLand1);
            this.Controls.Add(this.userLand1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.coeLogo);
            this.Controls.Add(this.acctManagePage1);
            this.Name = "WritingCenterScheduler";
            this.Text = "WC Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.coeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coeLogo;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private UserLand userLand1;
        private AdminLand adminLand1;
        private AcctManagePage acctManagePage1;
    }
}