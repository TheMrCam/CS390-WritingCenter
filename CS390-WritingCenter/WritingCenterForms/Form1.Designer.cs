namespace WritingCenterForms
{
    partial class Form1
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
            this.schedulePage1 = new WritingCenterForms.schedulePage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(265, 274);
            this.logIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(68, 30);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(244, 237);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(112, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(244, 205);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(112, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // schedulePage1
            // 
            this.schedulePage1.Location = new System.Drawing.Point(0, -2);
            this.schedulePage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedulePage1.Name = "schedulePage1";
            this.schedulePage1.Size = new System.Drawing.Size(599, 362);
            this.schedulePage1.TabIndex = 4;
            this.schedulePage1.Load += new System.EventHandler(this.schedulePage1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WritingCenterForms.Properties.Resources.Coe_College;
            this.pictureBox1.Location = new System.Drawing.Point(186, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.schedulePage1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WC Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private schedulePage schedulePage1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

