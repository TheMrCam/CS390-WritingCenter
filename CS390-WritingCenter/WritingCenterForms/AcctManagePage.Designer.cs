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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DBExportButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AcctDisplayListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadCsvButton
            // 
            this.uploadCsvButton.Location = new System.Drawing.Point(452, 87);
            this.uploadCsvButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uploadCsvButton.Name = "uploadCsvButton";
            this.uploadCsvButton.Size = new System.Drawing.Size(166, 44);
            this.uploadCsvButton.TabIndex = 0;
            this.uploadCsvButton.Text = "Upload CSV";
            this.uploadCsvButton.UseVisualStyleBackColor = true;
            this.uploadCsvButton.Click += new System.EventHandler(this.uploadCSV_Click);
            // 
            // viewAcctsButton
            // 
            this.viewAcctsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAcctsButton.Location = new System.Drawing.Point(28, 87);
            this.viewAcctsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewAcctsButton.Name = "viewAcctsButton";
            this.viewAcctsButton.Size = new System.Drawing.Size(166, 44);
            this.viewAcctsButton.TabIndex = 1;
            this.viewAcctsButton.Text = "View Current";
            this.viewAcctsButton.UseVisualStyleBackColor = true;
            this.viewAcctsButton.Click += new System.EventHandler(this.viewAcctsButton_Click);
            // 
            // manualEntryButton
            // 
            this.manualEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manualEntryButton.Location = new System.Drawing.Point(1214, 63);
            this.manualEntryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manualEntryButton.Name = "manualEntryButton";
            this.manualEntryButton.Size = new System.Drawing.Size(164, 44);
            this.manualEntryButton.TabIndex = 2;
            this.manualEntryButton.Text = "Manual Entry";
            this.manualEntryButton.UseVisualStyleBackColor = true;
            this.manualEntryButton.Click += new System.EventHandler(this.manualEntry_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "AcctCSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DBExportButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uploadCsvButton);
            this.panel1.Controls.Add(this.viewAcctsButton);
            this.panel1.Controls.Add(this.manualEntryButton);
            this.panel1.Location = new System.Drawing.Point(306, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 156);
            this.panel1.TabIndex = 4;
            // 
            // DBExportButton
            // 
            this.DBExportButton.Location = new System.Drawing.Point(452, 33);
            this.DBExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBExportButton.Name = "DBExportButton";
            this.DBExportButton.Size = new System.Drawing.Size(166, 44);
            this.DBExportButton.TabIndex = 5;
            this.DBExportButton.Text = "Export to CSV";
            this.DBExportButton.UseVisualStyleBackColor = true;
            this.DBExportButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "CLEAR DB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearDBClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(826, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refreshDatabase_click);
            // 
            // AcctDisplayListBox
            // 
            this.AcctDisplayListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AcctDisplayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctDisplayListBox.FormattingEnabled = true;
            this.AcctDisplayListBox.ItemHeight = 18;
            this.AcctDisplayListBox.Location = new System.Drawing.Point(306, 283);
            this.AcctDisplayListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AcctDisplayListBox.Name = "AcctDisplayListBox";
            this.AcctDisplayListBox.Size = new System.Drawing.Size(1398, 823);
            this.AcctDisplayListBox.TabIndex = 5;
            this.AcctDisplayListBox.SelectedIndexChanged += new System.EventHandler(this.AcctDisplayListBox_SelectedIndexChanged);
            this.AcctDisplayListBox.Enter += new System.EventHandler(this.refreshDatabase_click);
            // 
            // AcctManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AcctDisplayListBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AcctManagePage";
            this.Size = new System.Drawing.Size(1760, 1231);
            this.Load += new System.EventHandler(this.refreshDatabase_click);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadCsvButton;
        private System.Windows.Forms.Button viewAcctsButton;
        private System.Windows.Forms.Button manualEntryButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox AcctDisplayListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DBExportButton;
    }
}
