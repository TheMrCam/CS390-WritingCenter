namespace WritingCenterForms
{
    partial class AcctManagePage
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
            this.uploadCsvButton = new System.Windows.Forms.Button();
            this.viewAcctsButton = new System.Windows.Forms.Button();
            this.manualEntryButton = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadCsvButton
            // 
            this.uploadCsvButton.Location = new System.Drawing.Point(28, 88);
            this.uploadCsvButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uploadCsvButton.Name = "uploadCsvButton";
            this.uploadCsvButton.Size = new System.Drawing.Size(150, 44);
            this.uploadCsvButton.TabIndex = 0;
            this.uploadCsvButton.Text = "upload CSV";
            this.uploadCsvButton.UseVisualStyleBackColor = true;
            this.uploadCsvButton.Click += new System.EventHandler(this.uploadCSV_Click);
            // 
            // viewAcctsButton
            // 
            this.viewAcctsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAcctsButton.Location = new System.Drawing.Point(314, 88);
            this.viewAcctsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewAcctsButton.Name = "viewAcctsButton";
            this.viewAcctsButton.Size = new System.Drawing.Size(150, 44);
            this.viewAcctsButton.TabIndex = 1;
            this.viewAcctsButton.Text = "View Current";
            this.viewAcctsButton.UseVisualStyleBackColor = true;
            // 
            // manualEntryButton
            // 
            this.manualEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manualEntryButton.Location = new System.Drawing.Point(610, 88);
            this.manualEntryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manualEntryButton.Name = "manualEntryButton";
            this.manualEntryButton.Size = new System.Drawing.Size(164, 44);
            this.manualEntryButton.TabIndex = 2;
            this.manualEntryButton.Text = "Manual Entry";
            this.manualEntryButton.UseVisualStyleBackColor = true;
            this.manualEntryButton.Click += new System.EventHandler(this.manualEntry_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1300, 58);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(128, 58);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "AcctCSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uploadCsvButton);
            this.panel1.Controls.Add(this.viewAcctsButton);
            this.panel1.Controls.Add(this.manualEntryButton);
            this.panel1.Location = new System.Drawing.Point(402, 563);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 156);
            this.panel1.TabIndex = 4;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(615, 65);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(70, 25);
            this.HelloLabel.TabIndex = 5;
            this.HelloLabel.Text = "label1";
            this.HelloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AcctManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AcctManagePage";
            this.Size = new System.Drawing.Size(1760, 1231);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadCsvButton;
        private System.Windows.Forms.Button viewAcctsButton;
        private System.Windows.Forms.Button manualEntryButton;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HelloLabel;
    }
}
