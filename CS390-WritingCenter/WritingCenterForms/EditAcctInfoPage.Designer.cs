namespace WritingCenterForms
{
    partial class EditAcctInfoPage
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
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.requestedHours = new System.Windows.Forms.NumericUpDown();
            this.majors = new System.Windows.Forms.ListBox();
            this.isAdminBox = new System.Windows.Forms.CheckBox();
            this.LnameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedHours)).BeginInit();
            this.SuspendLayout();
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(194, 125);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(100, 20);
            this.FnameBox.TabIndex = 0;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(194, 302);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 2;
            // 
            // requestedHours
            // 
            this.requestedHours.Location = new System.Drawing.Point(194, 387);
            this.requestedHours.Name = "requestedHours";
            this.requestedHours.Size = new System.Drawing.Size(120, 20);
            this.requestedHours.TabIndex = 3;
            // 
            // majors
            // 
            this.majors.FormattingEnabled = true;
            this.majors.Location = new System.Drawing.Point(194, 445);
            this.majors.Name = "majors";
            this.majors.Size = new System.Drawing.Size(120, 95);
            this.majors.TabIndex = 4;
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.Location = new System.Drawing.Point(463, 523);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(55, 17);
            this.isAdminBox.TabIndex = 5;
            this.isAdminBox.Text = "Admin";
            this.isAdminBox.UseVisualStyleBackColor = true;
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(363, 125);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(100, 20);
            this.LnameBox.TabIndex = 6;
            // 
            // EditAcctInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LnameBox);
            this.Controls.Add(this.isAdminBox);
            this.Controls.Add(this.majors);
            this.Controls.Add(this.requestedHours);
            this.Controls.Add(this.year);
            this.Controls.Add(this.FnameBox);
            this.Name = "EditAcctInfoPage";
            this.Size = new System.Drawing.Size(750, 569);
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.NumericUpDown requestedHours;
        private System.Windows.Forms.ListBox majors;
        private System.Windows.Forms.CheckBox isAdminBox;
        private System.Windows.Forms.TextBox LnameBox;
    }
}
