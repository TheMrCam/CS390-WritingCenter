namespace WritingCenterForms
{
    partial class WCSchedulerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WCSchedulerForm));
            this.logIn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WC_LABEL = new System.Windows.Forms.Label();
            this.CWC_Logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bootRight = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CWC_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(719, 601);
            this.logIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(115, 62);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(624, 539);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(303, 30);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.enterPasswordBox);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordKeyPressed);
            this.password.Leave += new System.EventHandler(this.leftPasswordBox);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(624, 502);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(303, 30);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.enterUsernameBox);
            this.username.Leave += new System.EventHandler(this.leftUsernameBox);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.WC_LABEL);
            this.panel1.Controls.Add(this.CWC_Logo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.forgotPasswordButton);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 950);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Leave += new System.EventHandler(this.resetLogin);
            // 
            // WC_LABEL
            // 
            this.WC_LABEL.AutoSize = true;
            this.WC_LABEL.BackColor = System.Drawing.Color.MidnightBlue;
            this.WC_LABEL.Font = new System.Drawing.Font("Engravers MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC_LABEL.ForeColor = System.Drawing.Color.Goldenrod;
            this.WC_LABEL.Image = global::WritingCenterForms.Properties.Resources.bluebkgtext;
            this.WC_LABEL.Location = new System.Drawing.Point(504, 438);
            this.WC_LABEL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WC_LABEL.Name = "WC_LABEL";
            this.WC_LABEL.Size = new System.Drawing.Size(484, 47);
            this.WC_LABEL.TabIndex = 9;
            this.WC_LABEL.Text = "WC Schedueler";
            // 
            // CWC_Logo
            // 
            this.CWC_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CWC_Logo.BackColor = System.Drawing.Color.Transparent;
            this.CWC_Logo.BackgroundImage = global::WritingCenterForms.Properties.Resources.blueBkg;
            this.CWC_Logo.Image = ((System.Drawing.Image)(resources.GetObject("CWC_Logo.Image")));
            this.CWC_Logo.Location = new System.Drawing.Point(595, 151);
            this.CWC_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CWC_Logo.Name = "CWC_Logo";
            this.CWC_Logo.Size = new System.Drawing.Size(353, 319);
            this.CWC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CWC_Logo.TabIndex = 7;
            this.CWC_Logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1233, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.DatabaseDebug_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forgotPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordButton.Location = new System.Drawing.Point(29, 815);
            this.forgotPasswordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(117, 57);
            this.forgotPasswordButton.TabIndex = 4;
            this.forgotPasswordButton.Text = "Forgot Password";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WritingCenterForms.Properties.Resources.Background_Image;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1543, 919);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bootRight
            // 
            this.bootRight.Location = new System.Drawing.Point(415, 455);
            this.bootRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bootRight.Name = "bootRight";
            this.bootRight.Size = new System.Drawing.Size(132, 22);
            this.bootRight.TabIndex = 6;
            this.bootRight.Text = "test";
            // 
            // WCSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1532, 903);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bootRight);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WCSchedulerForm";
            this.Text = "WC Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.WCSchedulerForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CWC_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bootRight; // added to force GUI to not select username box as focus (therefore not displaying Username prompt) - AT
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox CWC_Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WC_LABEL;
    }
}

