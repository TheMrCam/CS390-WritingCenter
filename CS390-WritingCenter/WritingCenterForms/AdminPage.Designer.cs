namespace WritingCenterForms
{
    partial class AdminPage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settings = new FontAwesome.Sharp.IconButton();
            this.editRequests = new FontAwesome.Sharp.IconButton();
            this.manageAccounts = new FontAwesome.Sharp.IconButton();
            this.editSchedule = new FontAwesome.Sharp.IconButton();
            this.viewSchedule = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.logOutBtn = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconLogo = new FontAwesome.Sharp.IconPictureBox();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelMenu.Controls.Add(this.settings);
            this.panelMenu.Controls.Add(this.editRequests);
            this.panelMenu.Controls.Add(this.manageAccounts);
            this.panelMenu.Controls.Add(this.editSchedule);
            this.panelMenu.Controls.Add(this.viewSchedule);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(318, 800);
            this.panelMenu.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.settings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.settings.IconColor = System.Drawing.Color.WhiteSmoke;
            this.settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Location = new System.Drawing.Point(3, 483);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.settings.Size = new System.Drawing.Size(312, 72);
            this.settings.TabIndex = 6;
            this.settings.Tag = "Settings";
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // editRequests
            // 
            this.editRequests.FlatAppearance.BorderSize = 0;
            this.editRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRequests.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.editRequests.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.editRequests.IconColor = System.Drawing.Color.WhiteSmoke;
            this.editRequests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editRequests.Location = new System.Drawing.Point(3, 414);
            this.editRequests.Name = "editRequests";
            this.editRequests.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.editRequests.Size = new System.Drawing.Size(312, 72);
            this.editRequests.TabIndex = 5;
            this.editRequests.Tag = "Edit Requests";
            this.editRequests.Text = "Edit Requests";
            this.editRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editRequests.UseVisualStyleBackColor = true;
            this.editRequests.Click += new System.EventHandler(this.editRequests_Click);
            // 
            // manageAccounts
            // 
            this.manageAccounts.FlatAppearance.BorderSize = 0;
            this.manageAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccounts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.manageAccounts.IconChar = FontAwesome.Sharp.IconChar.User;
            this.manageAccounts.IconColor = System.Drawing.Color.WhiteSmoke;
            this.manageAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageAccounts.Location = new System.Drawing.Point(3, 347);
            this.manageAccounts.Name = "manageAccounts";
            this.manageAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.manageAccounts.Size = new System.Drawing.Size(312, 72);
            this.manageAccounts.TabIndex = 4;
            this.manageAccounts.Tag = "Manage Accounts";
            this.manageAccounts.Text = "Manage Accounts";
            this.manageAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageAccounts.UseVisualStyleBackColor = true;
            this.manageAccounts.Click += new System.EventHandler(this.manageAccounts_Click);
            // 
            // editSchedule
            // 
            this.editSchedule.FlatAppearance.BorderSize = 0;
            this.editSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSchedule.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.editSchedule.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.editSchedule.IconColor = System.Drawing.Color.WhiteSmoke;
            this.editSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editSchedule.Location = new System.Drawing.Point(3, 280);
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.editSchedule.Size = new System.Drawing.Size(312, 72);
            this.editSchedule.TabIndex = 3;
            this.editSchedule.Tag = "Edit Schedule";
            this.editSchedule.Text = "Edit Schedule";
            this.editSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editSchedule.UseVisualStyleBackColor = true;
            this.editSchedule.Click += new System.EventHandler(this.editSchedule_Click);
            // 
            // viewSchedule
            // 
            this.viewSchedule.FlatAppearance.BorderSize = 0;
            this.viewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSchedule.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewSchedule.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.viewSchedule.IconColor = System.Drawing.Color.WhiteSmoke;
            this.viewSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSchedule.Location = new System.Drawing.Point(3, 211);
            this.viewSchedule.Name = "viewSchedule";
            this.viewSchedule.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.viewSchedule.Size = new System.Drawing.Size(312, 72);
            this.viewSchedule.TabIndex = 2;
            this.viewSchedule.Tag = "View Schedule";
            this.viewSchedule.Text = "View Schedule";
            this.viewSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewSchedule.UseVisualStyleBackColor = true;
            this.viewSchedule.Click += new System.EventHandler(this.viewSchedule_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.menuButton);
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(312, 202);
            this.panelLogo.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuButton.IconColor = System.Drawing.Color.White;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.Location = new System.Drawing.Point(246, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(69, 54);
            this.menuButton.TabIndex = 7;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(318, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 94);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WritingCenterForms.Properties.Resources.CWC_logo_Red_Logomark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelTitle.Controls.Add(this.logOutBtn);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.iconLogo);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(318, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1082, 82);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutBtn.IconColor = System.Drawing.Color.White;
            this.logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutBtn.Location = new System.Drawing.Point(988, 27);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(91, 38);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTitle.Location = new System.Drawing.Point(82, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(236, 38);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Home";
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.iconLogo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconLogo.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.IconSize = 38;
            this.iconLogo.Location = new System.Drawing.Point(37, 22);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(39, 38);
            this.iconLogo.TabIndex = 0;
            this.iconLogo.TabStop = false;
            // 
            // userControlPanel
            // 
            this.userControlPanel.AutoScroll = true;
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(318, 82);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1082, 718);
            this.userControlPanel.TabIndex = 2;
            this.userControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userControlPanel_Paint);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton viewSchedule;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton settings;
        private FontAwesome.Sharp.IconButton editRequests;
        private FontAwesome.Sharp.IconButton manageAccounts;
        private FontAwesome.Sharp.IconButton editSchedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private System.Windows.Forms.Panel userControlPanel;
        private FontAwesome.Sharp.IconButton menuButton;
    }
}
