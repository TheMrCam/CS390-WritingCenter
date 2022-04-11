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
            this.orderLabel = new System.Windows.Forms.Label();
            this.shiftConLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.orderedBox = new System.Windows.Forms.ListBox();
            this.unorderedBox = new System.Windows.Forms.ListBox();
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
            this.panel1.Controls.Add(this.orderLabel);
            this.panel1.Controls.Add(this.shiftConLabel);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.orderedBox);
            this.panel1.Controls.Add(this.unorderedBox);
            this.panel1.Location = new System.Drawing.Point(2, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 560);
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
            this.tabControl1.Location = new System.Drawing.Point(1, 187);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 373);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SundayTab
            // 
            this.SundayTab.AutoScroll = true;
            this.SundayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayTab.Location = new System.Drawing.Point(4, 29);
            this.SundayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SundayTab.Name = "SundayTab";
            this.SundayTab.Size = new System.Drawing.Size(784, 340);
            this.SundayTab.TabIndex = 0;
            this.SundayTab.Text = "Sunday";
            this.SundayTab.UseVisualStyleBackColor = true;
            // 
            // MondayTab
            // 
            this.MondayTab.AutoScroll = true;
            this.MondayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayTab.Location = new System.Drawing.Point(4, 29);
            this.MondayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MondayTab.Name = "MondayTab";
            this.MondayTab.Size = new System.Drawing.Size(784, 340);
            this.MondayTab.TabIndex = 1;
            this.MondayTab.Text = "Monday";
            this.MondayTab.UseVisualStyleBackColor = true;
            // 
            // TuedayTab
            // 
            this.TuedayTab.AutoScroll = true;
            this.TuedayTab.Location = new System.Drawing.Point(4, 29);
            this.TuedayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TuedayTab.Name = "TuedayTab";
            this.TuedayTab.Size = new System.Drawing.Size(784, 340);
            this.TuedayTab.TabIndex = 2;
            this.TuedayTab.Text = "Tuesday";
            this.TuedayTab.UseVisualStyleBackColor = true;
            this.TuedayTab.Click += new System.EventHandler(this.TuedayTab_Click);
            // 
            // WednesdayTab
            // 
            this.WednesdayTab.AutoScroll = true;
            this.WednesdayTab.Location = new System.Drawing.Point(4, 29);
            this.WednesdayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WednesdayTab.Name = "WednesdayTab";
            this.WednesdayTab.Size = new System.Drawing.Size(784, 340);
            this.WednesdayTab.TabIndex = 3;
            this.WednesdayTab.Text = "Wednesday";
            this.WednesdayTab.UseVisualStyleBackColor = true;
            // 
            // ThursdayTab
            // 
            this.ThursdayTab.AutoScroll = true;
            this.ThursdayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayTab.Location = new System.Drawing.Point(4, 29);
            this.ThursdayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThursdayTab.Name = "ThursdayTab";
            this.ThursdayTab.Size = new System.Drawing.Size(784, 340);
            this.ThursdayTab.TabIndex = 4;
            this.ThursdayTab.Text = "Thursday";
            this.ThursdayTab.UseVisualStyleBackColor = true;
            // 
            // FridayTab
            // 
            this.FridayTab.AutoScroll = true;
            this.FridayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayTab.Location = new System.Drawing.Point(4, 29);
            this.FridayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FridayTab.Name = "FridayTab";
            this.FridayTab.Size = new System.Drawing.Size(784, 340);
            this.FridayTab.TabIndex = 5;
            this.FridayTab.Text = "Friday";
            this.FridayTab.UseVisualStyleBackColor = true;
            // 
            // SaturdayTab
            // 
            this.SaturdayTab.AutoScroll = true;
            this.SaturdayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayTab.Location = new System.Drawing.Point(4, 29);
            this.SaturdayTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaturdayTab.Name = "SaturdayTab";
            this.SaturdayTab.Size = new System.Drawing.Size(784, 340);
            this.SaturdayTab.TabIndex = 6;
            this.SaturdayTab.Text = "Saturday";
            this.SaturdayTab.UseVisualStyleBackColor = true;
            this.SaturdayTab.Click += new System.EventHandler(this.SaturdayTab_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(16, 25);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(157, 17);
            this.orderLabel.TabIndex = 16;
            this.orderLabel.Text = "Order by Preference";
            // 
            // shiftConLabel
            // 
            this.shiftConLabel.AutoSize = true;
            this.shiftConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftConLabel.Location = new System.Drawing.Point(16, 168);
            this.shiftConLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shiftConLabel.Name = "shiftConLabel";
            this.shiftConLabel.Size = new System.Drawing.Size(106, 17);
            this.shiftConLabel.TabIndex = 15;
            this.shiftConLabel.Text = "Shift Controls";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(302, 58);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 28);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderedBox
            // 
            this.orderedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBox.FormattingEnabled = true;
            this.orderedBox.ItemHeight = 17;
            this.orderedBox.Location = new System.Drawing.Point(170, 58);
            this.orderedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderedBox.Name = "orderedBox";
            this.orderedBox.Size = new System.Drawing.Size(113, 72);
            this.orderedBox.TabIndex = 6;
            // 
            // unorderedBox
            // 
            this.unorderedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unorderedBox.FormattingEnabled = true;
            this.unorderedBox.ItemHeight = 17;
            this.unorderedBox.Items.AddRange(new object[] {
            "Availability",
            "Experience",
            "Major & Minors",
            "Year"});
            this.unorderedBox.Location = new System.Drawing.Point(19, 58);
            this.unorderedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unorderedBox.Name = "unorderedBox";
            this.unorderedBox.Size = new System.Drawing.Size(113, 72);
            this.unorderedBox.TabIndex = 5;
            this.unorderedBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(353, 21);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(79, 41);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(810, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox orderedBox;
        private System.Windows.Forms.ListBox unorderedBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label shiftConLabel;
        private System.Windows.Forms.Label orderLabel;
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
