namespace WritingCenterForms
{
    partial class FirstSetup
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
            this.MasterUser_TextBox = new System.Windows.Forms.TextBox();
            this.MasterPassword_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MasterUser_TextBox
            // 
            this.MasterUser_TextBox.Location = new System.Drawing.Point(241, 206);
            this.MasterUser_TextBox.Name = "MasterUser_TextBox";
            this.MasterUser_TextBox.Size = new System.Drawing.Size(367, 31);
            this.MasterUser_TextBox.TabIndex = 0;
            // 
            // MasterPassword_TextBox
            // 
            this.MasterPassword_TextBox.Location = new System.Drawing.Point(241, 269);
            this.MasterPassword_TextBox.Name = "MasterPassword_TextBox";
            this.MasterPassword_TextBox.Size = new System.Drawing.Size(367, 31);
            this.MasterPassword_TextBox.TabIndex = 1;
            // 
            // FirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MasterPassword_TextBox);
            this.Controls.Add(this.MasterUser_TextBox);
            this.Name = "FirstSetup";
            this.Text = "FirstSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MasterUser_TextBox;
        private System.Windows.Forms.TextBox MasterPassword_TextBox;
    }
}