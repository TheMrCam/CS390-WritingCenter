namespace WritingCenterForms
{
    partial class schedulePage
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
            this.logOut = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(679, 33);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(85, 37);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(268, 117);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // schedulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.logOut);
            this.Name = "schedulePage";
            this.Size = new System.Drawing.Size(799, 445);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
