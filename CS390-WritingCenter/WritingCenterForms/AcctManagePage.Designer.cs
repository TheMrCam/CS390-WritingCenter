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
            this.uploadCsvButton.Location = new System.Drawing.Point(14, 46);
            this.uploadCsvButton.Name = "uploadCsvButton";
            this.uploadCsvButton.Size = new System.Drawing.Size(75, 23);
            this.uploadCsvButton.TabIndex = 0;
            this.uploadCsvButton.Text = "upload CSV";
            this.uploadCsvButton.UseVisualStyleBackColor = true;
            this.uploadCsvButton.Click += new System.EventHandler(this.uploadCSV_Click);
            // 
            // viewAcctsButton
            // 
            this.viewAcctsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAcctsButton.Location = new System.Drawing.Point(157, 46);
            this.viewAcctsButton.Name = "viewAcctsButton";
            this.viewAcctsButton.Size = new System.Drawing.Size(75, 23);
            this.viewAcctsButton.TabIndex = 1;
            this.viewAcctsButton.Text = "View Current";
            this.viewAcctsButton.UseVisualStyleBackColor = true;
            // 
            // manualEntryButton
            // 
            this.manualEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manualEntryButton.Location = new System.Drawing.Point(305, 46);
            this.manualEntryButton.Name = "manualEntryButton";
            this.manualEntryButton.Size = new System.Drawing.Size(82, 23);
            this.manualEntryButton.TabIndex = 2;
            this.manualEntryButton.Text = "Manual Entry";
            this.manualEntryButton.UseVisualStyleBackColor = true;
            this.manualEntryButton.Click += new System.EventHandler(this.manualEntry_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(650, 30);
            this.logOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(64, 30);
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
            this.panel1.Location = new System.Drawing.Point(201, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 81);
            this.panel1.TabIndex = 4;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(308, 34);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(35, 13);
            this.HelloLabel.TabIndex = 5;
            this.HelloLabel.Text = "label1";
            this.HelloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AcctManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Name = "AcctManagePage";
            this.Size = new System.Drawing.Size(880, 640);
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
