namespace WritingCenterForms
{
    partial class Alert
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnderHoursBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.OverHoursBox = new System.Windows.Forms.ListBox();
            this.NoHoursBox = new System.Windows.Forms.ListBox();
            this.UnderHoursLabel = new System.Windows.Forms.Label();
            this.OverHoursLabel = new System.Windows.Forms.Label();
            this.NoHoursLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnderHoursBox
            // 
            this.UnderHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderHoursBox.FormattingEnabled = true;
            this.UnderHoursBox.ItemHeight = 20;
            this.UnderHoursBox.Location = new System.Drawing.Point(11, 74);
            this.UnderHoursBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnderHoursBox.Name = "UnderHoursBox";
            this.UnderHoursBox.Size = new System.Drawing.Size(203, 284);
            this.UnderHoursBox.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(320, 409);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(67, 41);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // OverHoursBox
            // 
            this.OverHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverHoursBox.FormattingEnabled = true;
            this.OverHoursBox.ItemHeight = 20;
            this.OverHoursBox.Location = new System.Drawing.Point(251, 74);
            this.OverHoursBox.Margin = new System.Windows.Forms.Padding(2);
            this.OverHoursBox.Name = "OverHoursBox";
            this.OverHoursBox.Size = new System.Drawing.Size(203, 284);
            this.OverHoursBox.TabIndex = 2;
            // 
            // NoHoursBox
            // 
            this.NoHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHoursBox.FormattingEnabled = true;
            this.NoHoursBox.ItemHeight = 20;
            this.NoHoursBox.Location = new System.Drawing.Point(496, 74);
            this.NoHoursBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoHoursBox.Name = "NoHoursBox";
            this.NoHoursBox.Size = new System.Drawing.Size(203, 284);
            this.NoHoursBox.TabIndex = 3;
            // 
            // UnderHoursLabel
            // 
            this.UnderHoursLabel.AutoSize = true;
            this.UnderHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderHoursLabel.Location = new System.Drawing.Point(8, 53);
            this.UnderHoursLabel.Name = "UnderHoursLabel";
            this.UnderHoursLabel.Size = new System.Drawing.Size(100, 20);
            this.UnderHoursLabel.TabIndex = 4;
            this.UnderHoursLabel.Text = "Under Hours";
            // 
            // OverHoursLabel
            // 
            this.OverHoursLabel.AutoSize = true;
            this.OverHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverHoursLabel.Location = new System.Drawing.Point(248, 53);
            this.OverHoursLabel.Name = "OverHoursLabel";
            this.OverHoursLabel.Size = new System.Drawing.Size(89, 20);
            this.OverHoursLabel.TabIndex = 5;
            this.OverHoursLabel.Text = "Over Hours";
            // 
            // NoHoursLabel
            // 
            this.NoHoursLabel.AutoSize = true;
            this.NoHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHoursLabel.Location = new System.Drawing.Point(493, 53);
            this.NoHoursLabel.Name = "NoHoursLabel";
            this.NoHoursLabel.Size = new System.Drawing.Size(76, 20);
            this.NoHoursLabel.TabIndex = 6;
            this.NoHoursLabel.Text = "No Hours";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 461);
            this.Controls.Add(this.NoHoursLabel);
            this.Controls.Add(this.OverHoursLabel);
            this.Controls.Add(this.UnderHoursLabel);
            this.Controls.Add(this.NoHoursBox);
            this.Controls.Add(this.OverHoursBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.UnderHoursBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Alert";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UnderHoursBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox OverHoursBox;
        private System.Windows.Forms.ListBox NoHoursBox;
        private System.Windows.Forms.Label UnderHoursLabel;
        private System.Windows.Forms.Label OverHoursLabel;
        private System.Windows.Forms.Label NoHoursLabel;
    }
}