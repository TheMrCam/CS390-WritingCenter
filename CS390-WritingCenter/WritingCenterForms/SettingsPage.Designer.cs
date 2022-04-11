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
            this.HighLowHrs_Label = new System.Windows.Forms.Label();
            this.highLowBox = new System.Windows.Forms.CheckedListBox();
            this.numShiftsAllowed = new System.Windows.Forms.NumericUpDown();
            this.ConsShift_Label = new System.Windows.Forms.Label();
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
            this.univMaxWorkers_label = new System.Windows.Forms.Label();
            this.univMinWorkers_Label = new System.Windows.Forms.Label();
            this.univMinWorkers = new System.Windows.Forms.NumericUpDown();
            this.univMaxWorker = new System.Windows.Forms.NumericUpDown();
            this.setMaxWorkersButton = new System.Windows.Forms.Button();
            this.setMinWorkersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftsAllowed)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.univMinWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univMaxWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.setMinWorkersButton);
            this.panel1.Controls.Add(this.setMaxWorkersButton);
            this.panel1.Controls.Add(this.univMaxWorker);
            this.panel1.Controls.Add(this.univMinWorkers);
            this.panel1.Controls.Add(this.univMinWorkers_Label);
            this.panel1.Controls.Add(this.univMaxWorkers_label);
            this.panel1.Controls.Add(this.HighLowHrs_Label);
            this.panel1.Controls.Add(this.highLowBox);
            this.panel1.Controls.Add(this.numShiftsAllowed);
            this.panel1.Controls.Add(this.ConsShift_Label);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.orderLabel);
            this.panel1.Controls.Add(this.shiftConLabel);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.orderedBox);
            this.panel1.Controls.Add(this.unorderedBox);
            this.panel1.Location = new System.Drawing.Point(2, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 560);
            this.panel1.TabIndex = 1;
            // 
            // HighLowHrs_Label
            // 
            this.HighLowHrs_Label.AutoSize = true;
            this.HighLowHrs_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLowHrs_Label.Location = new System.Drawing.Point(591, 26);
            this.HighLowHrs_Label.Name = "HighLowHrs_Label";
            this.HighLowHrs_Label.Size = new System.Drawing.Size(198, 16);
            this.HighLowHrs_Label.TabIndex = 21;
            this.HighLowHrs_Label.Text = "Prioritize High or Low Hours";
            // 
            // highLowBox
            // 
            this.highLowBox.BackColor = System.Drawing.SystemColors.Window;
            this.highLowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLowBox.FormattingEnabled = true;
            this.highLowBox.Items.AddRange(new object[] {
            "high",
            "low"});
            this.highLowBox.Location = new System.Drawing.Point(594, 47);
            this.highLowBox.Name = "highLowBox";
            this.highLowBox.Size = new System.Drawing.Size(120, 38);
            this.highLowBox.TabIndex = 20;
            // 
            // numShiftsAllowed
            // 
            this.numShiftsAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShiftsAllowed.Location = new System.Drawing.Point(351, 47);
            this.numShiftsAllowed.Name = "numShiftsAllowed";
            this.numShiftsAllowed.Size = new System.Drawing.Size(120, 22);
            this.numShiftsAllowed.TabIndex = 19;
            // 
            // ConsShift_Label
            // 
            this.ConsShift_Label.AutoSize = true;
            this.ConsShift_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsShift_Label.Location = new System.Drawing.Point(348, 26);
            this.ConsShift_Label.Name = "ConsShift_Label";
            this.ConsShift_Label.Size = new System.Drawing.Size(193, 16);
            this.ConsShift_Label.TabIndex = 18;
            this.ConsShift_Label.Text = "Consecutive Shifts Allowed";
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 373);
            this.tabControl1.TabIndex = 17;
            // 
            // SundayTab
            // 
            this.SundayTab.AutoScroll = true;
            this.SundayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayTab.Location = new System.Drawing.Point(4, 29);
            this.SundayTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.MondayTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.TuedayTab.Margin = new System.Windows.Forms.Padding(2);
            this.TuedayTab.Name = "TuedayTab";
            this.TuedayTab.Size = new System.Drawing.Size(784, 340);
            this.TuedayTab.TabIndex = 2;
            this.TuedayTab.Text = "Tuesday";
            this.TuedayTab.UseVisualStyleBackColor = true;
            // 
            // WednesdayTab
            // 
            this.WednesdayTab.AutoScroll = true;
            this.WednesdayTab.Location = new System.Drawing.Point(4, 29);
            this.WednesdayTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.ThursdayTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.FridayTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.SaturdayTab.Margin = new System.Windows.Forms.Padding(2);
            this.SaturdayTab.Name = "SaturdayTab";
            this.SaturdayTab.Size = new System.Drawing.Size(784, 340);
            this.SaturdayTab.TabIndex = 6;
            this.SaturdayTab.Text = "Saturday";
            this.SaturdayTab.UseVisualStyleBackColor = true;
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
            this.resetButton.Location = new System.Drawing.Point(210, 25);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 28);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // orderedBox
            // 
            this.orderedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBox.FormattingEnabled = true;
            this.orderedBox.ItemHeight = 18;
            this.orderedBox.Location = new System.Drawing.Point(170, 58);
            this.orderedBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderedBox.Name = "orderedBox";
            this.orderedBox.Size = new System.Drawing.Size(147, 76);
            this.orderedBox.TabIndex = 6;
            // 
            // unorderedBox
            // 
            this.unorderedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unorderedBox.FormattingEnabled = true;
            this.unorderedBox.ItemHeight = 18;
            this.unorderedBox.Items.AddRange(new object[] {
            "Experience Mix",
            "Major & Minors Mix",
            "Class Year Mix"});
            this.unorderedBox.Location = new System.Drawing.Point(19, 58);
            this.unorderedBox.Margin = new System.Windows.Forms.Padding(2);
            this.unorderedBox.Name = "unorderedBox";
            this.unorderedBox.Size = new System.Drawing.Size(147, 76);
            this.unorderedBox.TabIndex = 5;
            this.unorderedBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.unorderedBox_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(353, 21);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(79, 41);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // univMaxWorkers_label
            // 
            this.univMaxWorkers_label.AutoSize = true;
            this.univMaxWorkers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.univMaxWorkers_label.Location = new System.Drawing.Point(348, 118);
            this.univMaxWorkers_label.Name = "univMaxWorkers_label";
            this.univMaxWorkers_label.Size = new System.Drawing.Size(138, 16);
            this.univMaxWorkers_label.TabIndex = 22;
            this.univMaxWorkers_label.Text = "Set All Maxworkers";
            // 
            // univMinWorkers_Label
            // 
            this.univMinWorkers_Label.AutoSize = true;
            this.univMinWorkers_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.univMinWorkers_Label.Location = new System.Drawing.Point(591, 118);
            this.univMinWorkers_Label.Name = "univMinWorkers_Label";
            this.univMinWorkers_Label.Size = new System.Drawing.Size(134, 16);
            this.univMinWorkers_Label.TabIndex = 23;
            this.univMinWorkers_Label.Text = "Set All Minworkers";
            // 
            // univMinWorkers
            // 
            this.univMinWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.univMinWorkers.Location = new System.Drawing.Point(594, 137);
            this.univMinWorkers.Name = "univMinWorkers";
            this.univMinWorkers.Size = new System.Drawing.Size(131, 22);
            this.univMinWorkers.TabIndex = 24;
            // 
            // univMaxWorker
            // 
            this.univMaxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.univMaxWorker.Location = new System.Drawing.Point(351, 137);
            this.univMaxWorker.Name = "univMaxWorker";
            this.univMaxWorker.Size = new System.Drawing.Size(135, 22);
            this.univMaxWorker.TabIndex = 25;
            // 
            // setMaxWorkersButton
            // 
            this.setMaxWorkersButton.Location = new System.Drawing.Point(492, 136);
            this.setMaxWorkersButton.Name = "setMaxWorkersButton";
            this.setMaxWorkersButton.Size = new System.Drawing.Size(57, 23);
            this.setMaxWorkersButton.TabIndex = 26;
            this.setMaxWorkersButton.Text = "Set";
            this.setMaxWorkersButton.UseVisualStyleBackColor = true;
            this.setMaxWorkersButton.Click += new System.EventHandler(this.setMaxWorkersButton_Click);
            // 
            // setMinWorkersButton
            // 
            this.setMinWorkersButton.Location = new System.Drawing.Point(731, 137);
            this.setMinWorkersButton.Name = "setMinWorkersButton";
            this.setMinWorkersButton.Size = new System.Drawing.Size(57, 23);
            this.setMinWorkersButton.TabIndex = 27;
            this.setMinWorkersButton.Text = "Set";
            this.setMinWorkersButton.UseVisualStyleBackColor = true;
            this.setMinWorkersButton.Click += new System.EventHandler(this.setMinWorkersButton_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(810, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftsAllowed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.univMinWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univMaxWorker)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numShiftsAllowed;
        private System.Windows.Forms.Label ConsShift_Label;
        private System.Windows.Forms.Label HighLowHrs_Label;
        private System.Windows.Forms.CheckedListBox highLowBox;
        private System.Windows.Forms.NumericUpDown univMaxWorker;
        private System.Windows.Forms.NumericUpDown univMinWorkers;
        private System.Windows.Forms.Label univMinWorkers_Label;
        private System.Windows.Forms.Label univMaxWorkers_label;
        private System.Windows.Forms.Button setMinWorkersButton;
        private System.Windows.Forms.Button setMaxWorkersButton;
    }
}
