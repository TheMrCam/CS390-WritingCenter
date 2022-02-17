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
            this.logOut = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedHours)).BeginInit();
            this.SuspendLayout();
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(219, 212);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(100, 20);
            this.FnameBox.TabIndex = 0;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(219, 261);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 2;
            // 
            // requestedHours
            // 
            this.requestedHours.Location = new System.Drawing.Point(219, 307);
            this.requestedHours.Name = "requestedHours";
            this.requestedHours.Size = new System.Drawing.Size(120, 20);
            this.requestedHours.TabIndex = 3;
            // 
            // majors
            // 
            this.majors.FormattingEnabled = true;
            this.majors.Items.AddRange(new object[] {
            "Computer Science",
            "Data Science",
            "Psychology",
            "Philosiphy"});
            this.majors.Location = new System.Drawing.Point(388, 261);
            this.majors.Name = "majors";
            this.majors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.majors.Size = new System.Drawing.Size(120, 95);
            this.majors.TabIndex = 4;
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.Location = new System.Drawing.Point(219, 339);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(55, 17);
            this.isAdminBox.TabIndex = 5;
            this.isAdminBox.Text = "Admin";
            this.isAdminBox.UseVisualStyleBackColor = true;
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(388, 212);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(100, 20);
            this.LnameBox.TabIndex = 6;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(664, 25);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(64, 30);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(46, 36);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(74, 33);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Location = new System.Drawing.Point(216, 196);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(57, 13);
            this.FnameLabel.TabIndex = 19;
            this.FnameLabel.Text = "First Name";
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Location = new System.Drawing.Point(385, 196);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(58, 13);
            this.LnameLabel.TabIndex = 20;
            this.LnameLabel.Text = "Last Name";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(216, 245);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 21;
            this.yearLabel.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hours Requested";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(385, 245);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(44, 13);
            this.majorLabel.TabIndex = 23;
            this.majorLabel.Text = "Major(s)";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(302, 390);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(102, 49);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // EditAcctInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.LnameLabel);
            this.Controls.Add(this.FnameLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.logOut);
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
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Button submitButton;
    }
}
