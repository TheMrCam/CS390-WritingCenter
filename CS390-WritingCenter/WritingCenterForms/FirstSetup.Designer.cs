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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadCSV_button = new System.Windows.Forms.Button();
            this.FileName_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DefaultPass_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MasterUser_TextBox
            // 
            this.MasterUser_TextBox.Location = new System.Drawing.Point(317, 86);
            this.MasterUser_TextBox.Name = "MasterUser_TextBox";
            this.MasterUser_TextBox.Size = new System.Drawing.Size(367, 31);
            this.MasterUser_TextBox.TabIndex = 0;
            // 
            // MasterPassword_TextBox
            // 
            this.MasterPassword_TextBox.Location = new System.Drawing.Point(317, 143);
            this.MasterPassword_TextBox.Name = "MasterPassword_TextBox";
            this.MasterPassword_TextBox.Size = new System.Drawing.Size(367, 31);
            this.MasterPassword_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Master Password";
            // 
            // UploadCSV_button
            // 
            this.UploadCSV_button.Location = new System.Drawing.Point(130, 263);
            this.UploadCSV_button.Name = "UploadCSV_button";
            this.UploadCSV_button.Size = new System.Drawing.Size(173, 63);
            this.UploadCSV_button.TabIndex = 4;
            this.UploadCSV_button.Text = "Upload Accounts CSV";
            this.UploadCSV_button.UseVisualStyleBackColor = true;
            this.UploadCSV_button.Click += new System.EventHandler(this.UploadCSV_button_Click);
            // 
            // FileName_label
            // 
            this.FileName_label.AutoSize = true;
            this.FileName_label.Location = new System.Drawing.Point(328, 282);
            this.FileName_label.Name = "FileName_label";
            this.FileName_label.Size = new System.Drawing.Size(160, 25);
            this.FileName_label.TabIndex = 5;
            this.FileName_label.Text = "No file selected";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(649, 352);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(73, 51);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Default User Password";
            // 
            // DefaultPass_TextBox
            // 
            this.DefaultPass_TextBox.Location = new System.Drawing.Point(317, 204);
            this.DefaultPass_TextBox.Name = "DefaultPass_TextBox";
            this.DefaultPass_TextBox.Size = new System.Drawing.Size(367, 31);
            this.DefaultPass_TextBox.TabIndex = 7;
            // 
            // FirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DefaultPass_TextBox);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.FileName_label);
            this.Controls.Add(this.UploadCSV_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasterPassword_TextBox);
            this.Controls.Add(this.MasterUser_TextBox);
            this.Name = "FirstSetup";
            this.Text = "First Time Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MasterUser_TextBox;
        private System.Windows.Forms.TextBox MasterPassword_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UploadCSV_button;
        private System.Windows.Forms.Label FileName_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DefaultPass_TextBox;
    }
}