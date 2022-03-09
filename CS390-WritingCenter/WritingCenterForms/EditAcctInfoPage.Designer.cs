namespace WritingCenterForms
{
    partial class EditAcctInfoPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// List of majors offered
        /// </summary>

        private object majorsList = new object[] {
            "Computer Science",
            "Data Science",
            "Psychology",
            "Philosiphy"};

        /// <summary>
        /// List of minors offered
        /// </summary>

        private object minorsList = new object[] {
            "Computer Science",
            "Data Science",
            "Psychology",
            "Philosiphy"};

        private object hoursList = new object[]
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"
        };



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
        ///
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        
        private void InitializeComponent()
        {
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.requestedHours = new System.Windows.Forms.NumericUpDown();
            this.majorsBox = new System.Windows.Forms.ListBox();
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
            this.minorsBox = new System.Windows.Forms.Label();
            this.minorBox = new System.Windows.Forms.ListBox();
            this.monHrBox = new System.Windows.Forms.CheckedListBox();
            this.tuesHrBox = new System.Windows.Forms.CheckedListBox();
            this.wedHrBox = new System.Windows.Forms.CheckedListBox();
            this.thHrBox = new System.Windows.Forms.CheckedListBox();
            this.friHrBox = new System.Windows.Forms.CheckedListBox();
            this.satHrBox = new System.Windows.Forms.CheckedListBox();
            this.availibilityLabel = new System.Windows.Forms.Label();
            this.wedLabel = new System.Windows.Forms.Label();
            this.monLabel = new System.Windows.Forms.Label();
            this.tuesLabel = new System.Windows.Forms.Label();
            this.sunHrBox = new System.Windows.Forms.CheckedListBox();
            this.thursLabel = new System.Windows.Forms.Label();
            this.friLabel = new System.Windows.Forms.Label();
            this.satLabel = new System.Windows.Forms.Label();
            this.sunLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedHours)).BeginInit();
            this.SuspendLayout();
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(268, 350);
            this.FnameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(236, 31);
            this.FnameBox.TabIndex = 0;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(268, 483);
            this.year.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(240, 31);
            this.year.TabIndex = 2;
            // 
            // requestedHours
            // 
            this.requestedHours.Location = new System.Drawing.Point(650, 483);
            this.requestedHours.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.requestedHours.Name = "requestedHours";
            this.requestedHours.Size = new System.Drawing.Size(240, 31);
            this.requestedHours.TabIndex = 3;
            // 
            // majorsBox
            // 
            this.majorsBox.FormattingEnabled = true;
            this.majorsBox.ItemHeight = 25;
            this.majorsBox.Location = new System.Drawing.Point(1070, 350);
            this.majorsBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.majorsBox.Name = "majorsBox";
            this.majorsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.majorsBox.Size = new System.Drawing.Size(236, 179);
            this.majorsBox.TabIndex = 4;
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.Location = new System.Drawing.Point(654, 1072);
            this.isAdminBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(104, 29);
            this.isAdminBox.TabIndex = 5;
            this.isAdminBox.Text = "Admin";
            this.isAdminBox.UseVisualStyleBackColor = true;
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(648, 350);
            this.LnameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(236, 31);
            this.LnameBox.TabIndex = 6;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1552, 69);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(128, 58);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(92, 69);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(148, 64);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(262, 309);
            this.FnameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(158, 36);
            this.FnameLabel.TabIndex = 19;
            this.FnameLabel.Text = "First Name";
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(642, 309);
            this.LnameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(156, 36);
            this.LnameLabel.TabIndex = 20;
            this.LnameLabel.Text = "Last Name";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(260, 442);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(77, 36);
            this.yearLabel.TabIndex = 21;
            this.yearLabel.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hours Requested";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(1064, 309);
            this.majorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(125, 36);
            this.majorLabel.TabIndex = 23;
            this.majorLabel.Text = "Major(s)";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(776, 1039);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(204, 94);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submit_Click);
            // 
            // minorsBox
            // 
            this.minorsBox.AutoSize = true;
            this.minorsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorsBox.Location = new System.Drawing.Point(1434, 309);
            this.minorsBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minorsBox.Name = "minorsBox";
            this.minorsBox.Size = new System.Drawing.Size(126, 36);
            this.minorsBox.TabIndex = 26;
            this.minorsBox.Text = "Minor(s)";
            this.minorsBox.Click += new System.EventHandler(this.label2_Click);
            // 
            // minorBox
            // 
            this.minorBox.FormattingEnabled = true;
            this.minorBox.ItemHeight = 25;
            this.minorBox.Location = new System.Drawing.Point(1440, 350);
            this.minorBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minorBox.Name = "minorBox";
            this.minorBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.minorBox.Size = new System.Drawing.Size(236, 179);
            this.minorBox.TabIndex = 25;
            this.minorBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // monHrBox
            // 
            this.monHrBox.FormattingEnabled = true;
            this.monHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.monHrBox.Location = new System.Drawing.Point(54, 697);
            this.monHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monHrBox.Name = "monHrBox";
            this.monHrBox.Size = new System.Drawing.Size(218, 116);
            this.monHrBox.TabIndex = 27;
            // 
            // tuesHrBox
            // 
            this.tuesHrBox.FormattingEnabled = true;
            this.tuesHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.tuesHrBox.Location = new System.Drawing.Point(288, 697);
            this.tuesHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tuesHrBox.Name = "tuesHrBox";
            this.tuesHrBox.Size = new System.Drawing.Size(218, 116);
            this.tuesHrBox.TabIndex = 28;
            // 
            // wedHrBox
            // 
            this.wedHrBox.FormattingEnabled = true;
            this.wedHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.wedHrBox.Location = new System.Drawing.Point(522, 697);
            this.wedHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.wedHrBox.Name = "wedHrBox";
            this.wedHrBox.Size = new System.Drawing.Size(218, 116);
            this.wedHrBox.TabIndex = 29;
            // 
            // thHrBox
            // 
            this.thHrBox.FormattingEnabled = true;
            this.thHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.thHrBox.Location = new System.Drawing.Point(756, 697);
            this.thHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.thHrBox.Name = "thHrBox";
            this.thHrBox.Size = new System.Drawing.Size(218, 116);
            this.thHrBox.TabIndex = 30;
            // 
            // friHrBox
            // 
            this.friHrBox.FormattingEnabled = true;
            this.friHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.friHrBox.Location = new System.Drawing.Point(992, 697);
            this.friHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.friHrBox.Name = "friHrBox";
            this.friHrBox.Size = new System.Drawing.Size(218, 116);
            this.friHrBox.TabIndex = 31;
            // 
            // satHrBox
            // 
            this.satHrBox.FormattingEnabled = true;
            this.satHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.satHrBox.Location = new System.Drawing.Point(1226, 697);
            this.satHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.satHrBox.Name = "satHrBox";
            this.satHrBox.Size = new System.Drawing.Size(218, 116);
            this.satHrBox.TabIndex = 32;
            // 
            // availibilityLabel
            // 
            this.availibilityLabel.AutoSize = true;
            this.availibilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availibilityLabel.Location = new System.Drawing.Point(44, 600);
            this.availibilityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.availibilityLabel.Name = "availibilityLabel";
            this.availibilityLabel.Size = new System.Drawing.Size(231, 55);
            this.availibilityLabel.TabIndex = 33;
            this.availibilityLabel.Text = "Availibility";
            // 
            // wedLabel
            // 
            this.wedLabel.AutoSize = true;
            this.wedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wedLabel.Location = new System.Drawing.Point(516, 656);
            this.wedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(173, 36);
            this.wedLabel.TabIndex = 34;
            this.wedLabel.Text = "Wednesday";
            // 
            // monLabel
            // 
            this.monLabel.AutoSize = true;
            this.monLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monLabel.Location = new System.Drawing.Point(48, 656);
            this.monLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(122, 36);
            this.monLabel.TabIndex = 35;
            this.monLabel.Text = "Monday";
            // 
            // tuesLabel
            // 
            this.tuesLabel.AutoSize = true;
            this.tuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesLabel.Location = new System.Drawing.Point(282, 656);
            this.tuesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tuesLabel.Name = "tuesLabel";
            this.tuesLabel.Size = new System.Drawing.Size(129, 36);
            this.tuesLabel.TabIndex = 36;
            this.tuesLabel.Text = "Tuesday";
            // 
            // sunHrBox
            // 
            this.sunHrBox.FormattingEnabled = true;
            this.sunHrBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.sunHrBox.Location = new System.Drawing.Point(1462, 697);
            this.sunHrBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sunHrBox.Name = "sunHrBox";
            this.sunHrBox.Size = new System.Drawing.Size(218, 116);
            this.sunHrBox.TabIndex = 37;
            this.sunHrBox.SelectedIndexChanged += new System.EventHandler(this.sunHrBox_SelectedIndexChanged);
            // 
            // thursLabel
            // 
            this.thursLabel.AutoSize = true;
            this.thursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursLabel.Location = new System.Drawing.Point(750, 656);
            this.thursLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.thursLabel.Name = "thursLabel";
            this.thursLabel.Size = new System.Drawing.Size(140, 36);
            this.thursLabel.TabIndex = 38;
            this.thursLabel.Text = "Thursday";
            // 
            // friLabel
            // 
            this.friLabel.AutoSize = true;
            this.friLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friLabel.Location = new System.Drawing.Point(986, 656);
            this.friLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(98, 36);
            this.friLabel.TabIndex = 39;
            this.friLabel.Text = "Friday";
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satLabel.Location = new System.Drawing.Point(1220, 656);
            this.satLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(134, 36);
            this.satLabel.TabIndex = 40;
            this.satLabel.Text = "Saturday";
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLabel.Location = new System.Drawing.Point(1456, 656);
            this.sunLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(117, 36);
            this.sunLabel.TabIndex = 41;
            this.sunLabel.Text = "Sunday";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 202);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 31);
            this.textBox1.TabIndex = 42;
            // 
            // usernameBox
            // 
            this.usernameBox.AutoSize = true;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(196, 153);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(150, 36);
            this.usernameBox.TabIndex = 43;
            this.usernameBox.Text = "Username";
            // 
            // EditAcctInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sunLabel);
            this.Controls.Add(this.satLabel);
            this.Controls.Add(this.friLabel);
            this.Controls.Add(this.thursLabel);
            this.Controls.Add(this.sunHrBox);
            this.Controls.Add(this.tuesLabel);
            this.Controls.Add(this.monLabel);
            this.Controls.Add(this.wedLabel);
            this.Controls.Add(this.availibilityLabel);
            this.Controls.Add(this.satHrBox);
            this.Controls.Add(this.friHrBox);
            this.Controls.Add(this.thHrBox);
            this.Controls.Add(this.wedHrBox);
            this.Controls.Add(this.tuesHrBox);
            this.Controls.Add(this.monHrBox);
            this.Controls.Add(this.minorsBox);
            this.Controls.Add(this.minorBox);
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
            this.Controls.Add(this.majorsBox);
            this.Controls.Add(this.requestedHours);
            this.Controls.Add(this.year);
            this.Controls.Add(this.FnameBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditAcctInfoPage";
            this.Size = new System.Drawing.Size(1760, 1231);
            this.Load += new System.EventHandler(this.EditAcctInfoPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.NumericUpDown requestedHours;
        private System.Windows.Forms.ListBox majorsBox;
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
        private System.Windows.Forms.Label minorsBox;
        private System.Windows.Forms.ListBox minorBox;
        private System.Windows.Forms.CheckedListBox monHrBox;
        private System.Windows.Forms.CheckedListBox tuesHrBox;
        private System.Windows.Forms.CheckedListBox wedHrBox;
        private System.Windows.Forms.CheckedListBox thHrBox;
        private System.Windows.Forms.CheckedListBox friHrBox;
        private System.Windows.Forms.CheckedListBox satHrBox;
        private System.Windows.Forms.CheckedListBox sunHrBox;
        private System.Windows.Forms.Label availibilityLabel;
        private System.Windows.Forms.Label wedLabel;
        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Label tuesLabel;
        private System.Windows.Forms.Label thursLabel;
        private System.Windows.Forms.Label friLabel;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usernameBox;
    }
}
