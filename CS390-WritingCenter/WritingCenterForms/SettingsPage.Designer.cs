namespace WritingCenterForms
{
    partial class SettingsPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SundayTab = new System.Windows.Forms.TabPage();
            this.MondayTab = new System.Windows.Forms.TabPage();
            this.TuedayTab = new System.Windows.Forms.TabPage();
            this.WednesdayTab = new System.Windows.Forms.TabPage();
            this.ThursdayTab = new System.Windows.Forms.TabPage();
            this.FridayTab = new System.Windows.Forms.TabPage();
            this.SaturdayTab = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(3, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 689);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SundayTab);
            this.tabControl1.Controls.Add(this.MondayTab);
            this.tabControl1.Controls.Add(this.TuedayTab);
            this.tabControl1.Controls.Add(this.WednesdayTab);
            this.tabControl1.Controls.Add(this.ThursdayTab);
            this.tabControl1.Controls.Add(this.FridayTab);
            this.tabControl1.Controls.Add(this.SaturdayTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 459);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SundayTab
            // 
            this.SundayTab.AutoScroll = true;
            this.SundayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayTab.Location = new System.Drawing.Point(4, 34);
            this.SundayTab.Name = "SundayTab";
            this.SundayTab.Size = new System.Drawing.Size(1048, 421);
            this.SundayTab.TabIndex = 0;
            this.SundayTab.Text = "Sunday";
            this.SundayTab.UseVisualStyleBackColor = true;
            // 
            // MondayTab
            // 
            this.MondayTab.AutoScroll = true;
            this.MondayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayTab.Location = new System.Drawing.Point(4, 34);
            this.MondayTab.Name = "MondayTab";
            this.MondayTab.Size = new System.Drawing.Size(1048, 421);
            this.MondayTab.TabIndex = 1;
            this.MondayTab.Text = "Monday";
            this.MondayTab.UseVisualStyleBackColor = true;
            // 
            // TuedayTab
            // 
            this.TuedayTab.AutoScroll = true;
            this.TuedayTab.Location = new System.Drawing.Point(4, 34);
            this.TuedayTab.Name = "TuedayTab";
            this.TuedayTab.Size = new System.Drawing.Size(1048, 421);
            this.TuedayTab.TabIndex = 2;
            this.TuedayTab.Text = "Tuesday";
            this.TuedayTab.UseVisualStyleBackColor = true;
            this.TuedayTab.Click += new System.EventHandler(this.TuedayTab_Click);
            // 
            // WednesdayTab
            // 
            this.WednesdayTab.AutoScroll = true;
            this.WednesdayTab.Location = new System.Drawing.Point(4, 34);
            this.WednesdayTab.Name = "WednesdayTab";
            this.WednesdayTab.Size = new System.Drawing.Size(1048, 421);
            this.WednesdayTab.TabIndex = 3;
            this.WednesdayTab.Text = "Wednesday";
            this.WednesdayTab.UseVisualStyleBackColor = true;
            // 
            // ThursdayTab
            // 
            this.ThursdayTab.AutoScroll = true;
            this.ThursdayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayTab.Location = new System.Drawing.Point(4, 34);
            this.ThursdayTab.Name = "ThursdayTab";
            this.ThursdayTab.Size = new System.Drawing.Size(1048, 421);
            this.ThursdayTab.TabIndex = 4;
            this.ThursdayTab.Text = "Thursday";
            this.ThursdayTab.UseVisualStyleBackColor = true;
            // 
            // FridayTab
            // 
            this.FridayTab.AutoScroll = true;
            this.FridayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayTab.Location = new System.Drawing.Point(4, 34);
            this.FridayTab.Name = "FridayTab";
            this.FridayTab.Size = new System.Drawing.Size(1048, 421);
            this.FridayTab.TabIndex = 5;
            this.FridayTab.Text = "Friday";
            this.FridayTab.UseVisualStyleBackColor = true;
            // 
            // SaturdayTab
            // 
            this.SaturdayTab.AutoScroll = true;
            this.SaturdayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayTab.Location = new System.Drawing.Point(4, 34);
            this.SaturdayTab.Name = "SaturdayTab";
            this.SaturdayTab.Size = new System.Drawing.Size(1048, 421);
            this.SaturdayTab.TabIndex = 6;
            this.SaturdayTab.Text = "Saturday";
            this.SaturdayTab.UseVisualStyleBackColor = true;
            this.SaturdayTab.Click += new System.EventHandler(this.SaturdayTab_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "Order by Preference";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 207);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 20);
            this.label22.TabIndex = 15;
            this.label22.Text = "Shift Controls";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(227, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 104);
            this.listBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Availability",
            "Experience",
            "Major & Minors",
            "Year"});
            this.listBox1.Location = new System.Drawing.Point(25, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 104);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(471, 26);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(105, 50);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(1080, 800);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SundayTab;
        private System.Windows.Forms.TabPage MondayTab;
        private System.Windows.Forms.TabPage ThursdayTab;
        private System.Windows.Forms.TabPage FridayTab;
        private System.Windows.Forms.TabPage SaturdayTab;
        private System.Windows.Forms.TabPage TuedayTab;
        private System.Windows.Forms.TabPage WednesdayTab;
        private System.Windows.Forms.Button submitButton;
    }
}
