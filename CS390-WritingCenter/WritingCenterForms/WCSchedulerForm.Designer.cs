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
            this.logIn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.bootRight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn.Location = new System.Drawing.Point(788, 765);
            this.logIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(158, 79);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(652, 717);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(452, 31);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.enterPasswordBox);
            this.password.Leave += new System.EventHandler(this.leftPasswordBox);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Location = new System.Drawing.Point(652, 648);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(452, 31);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.forgotPasswordButton);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 1231);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Leave += new System.EventHandler(this.resetLogin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(406, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 312);
            this.label1.TabIndex = 5;
            this.label1.Text = "Writing Center\r\n Scheduler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Location = new System.Drawing.Point(28, 1125);
            this.forgotPasswordButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(158, 79);
            this.forgotPasswordButton.TabIndex = 4;
            this.forgotPasswordButton.Text = "Forgot Password";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            // 
            // bootRight
            // 
            this.bootRight.Location = new System.Drawing.Point(622, 713);
            this.bootRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bootRight.Name = "bootRight";
            this.bootRight.Size = new System.Drawing.Size(196, 31);
            this.bootRight.TabIndex = 6;
            this.bootRight.Text = "test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1574, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DatabaseDebug_Click);
            // 
            // WCSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1752, 1225);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bootRight);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WCSchedulerForm";
            this.Text = "WC Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button button1;
    }
}

