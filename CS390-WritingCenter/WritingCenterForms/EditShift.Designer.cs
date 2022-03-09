namespace WritingCenterForms
{
    partial class EditShift
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.removeWorkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(28, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 179);
            this.listBox1.TabIndex = 0;
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(68, 269);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(111, 45);
            this.addWorkerButton.TabIndex = 1;
            this.addWorkerButton.Text = "Add New Worker";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // removeWorkerButton
            // 
            this.removeWorkerButton.Location = new System.Drawing.Point(195, 269);
            this.removeWorkerButton.Name = "removeWorkerButton";
            this.removeWorkerButton.Size = new System.Drawing.Size(111, 45);
            this.removeWorkerButton.TabIndex = 2;
            this.removeWorkerButton.Text = "Remove Worker";
            this.removeWorkerButton.UseVisualStyleBackColor = true;
            this.removeWorkerButton.Click += new System.EventHandler(this.removeWorkerButton_Click);
            // 
            // EditShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 353);
            this.Controls.Add(this.removeWorkerButton);
            this.Controls.Add(this.addWorkerButton);
            this.Controls.Add(this.listBox1);
            this.Name = "EditShift";
            this.Text = "EditShift";
            this.Load += new System.EventHandler(this.EditShift_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.Button removeWorkerButton;
    }
}