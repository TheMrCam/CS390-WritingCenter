namespace WritingCenterForms
{
    partial class UserLand
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
            this.schedulePlacehold = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitEditReqButton = new System.Windows.Forms.Button();
            this.schedButton = new System.Windows.Forms.Button();
            this.coeLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(509, 22);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(64, 30);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // schedulePlacehold
            // 
            this.schedulePlacehold.Location = new System.Drawing.Point(346, 76);
            this.schedulePlacehold.Name = "schedulePlacehold";
            this.schedulePlacehold.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submitEditReqButton);
            this.panel1.Controls.Add(this.schedButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 95);
            this.panel1.TabIndex = 7;
            // 
            // submitEditReqButton
            // 
            this.submitEditReqButton.Location = new System.Drawing.Point(346, 26);
            this.submitEditReqButton.Name = "submitEditReqButton";
            this.submitEditReqButton.Size = new System.Drawing.Size(95, 44);
            this.submitEditReqButton.TabIndex = 2;
            this.submitEditReqButton.Text = "Submit Edit Request";
            this.submitEditReqButton.UseVisualStyleBackColor = true;
            // 
            // schedButton
            // 
            this.schedButton.Location = new System.Drawing.Point(154, 26);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(95, 44);
            this.schedButton.TabIndex = 0;
            this.schedButton.Text = "View Schedule";
            this.schedButton.UseVisualStyleBackColor = true;
            // 
            // coeLogo
            // 
            this.coeLogo.Image = global::WritingCenterForms.Properties.Resources.Coe_College;
            this.coeLogo.Location = new System.Drawing.Point(22, 76);
            this.coeLogo.Margin = new System.Windows.Forms.Padding(2);
            this.coeLogo.Name = "coeLogo";
            this.coeLogo.Size = new System.Drawing.Size(227, 162);
            this.coeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coeLogo.TabIndex = 5;
            this.coeLogo.TabStop = false;
            // 
            // UserLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.schedulePlacehold);
            this.Controls.Add(this.coeLogo);
            this.Controls.Add(this.logOut);
            this.Name = "UserLand";
            this.Size = new System.Drawing.Size(600, 375);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.PictureBox coeLogo;
        private System.Windows.Forms.MonthCalendar schedulePlacehold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitEditReqButton;
        private System.Windows.Forms.Button schedButton;
    }
}
