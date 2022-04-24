using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class shiftControl : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private NumericUpDown minNumericUpDown;
        private NumericUpDown maxNumericUpDown;
        private CheckBox checkBox2;
        private Label labels;
        public int[] minWorker = new int[24];
        public int[] maxWorker = new int[24];
        public bool[] openHours = new bool[24] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false};
        public bool[] busyShifts = new bool[24] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

        public int defaultMinWorker = 1;
        public int defaultMaxWorker = 4;
        private CheckBox checkBox3;

        public shiftControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Controls.Add(loadShiftControls());
            this.BackColor = Color.Wheat;
        }

        public TableLayoutPanel loadShiftControls()
        {
            this.Controls.Clear();

            tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 25;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            int tabIndex = 0;
            this.tableLayoutPanel1.Controls.Add(createLabel(0, "Open Hours"), 0, 0);
            this.tableLayoutPanel1.Controls.Add(createLabel(1, "Min Workers"), 1, 0);
            this.tableLayoutPanel1.Controls.Add(createLabel(2, "Max Workers"), 2, 0);
            this.tableLayoutPanel1.Controls.Add(createLabel(3, "Busy"), 3, 0);

            for (int i = 0; i < 24; i++)
            {
                this.tableLayoutPanel1.Controls.Add(createOpenHourCheckboxes(i, tabIndex), 0, i+1);
                this.tableLayoutPanel1.Controls.Add(createMinNumericUpDown(i, tabIndex++), 1, i+1);
                this.tableLayoutPanel1.Controls.Add(createMaxNumericUpDown(i, tabIndex++), 2, i+1);
                this.tableLayoutPanel1.Controls.Add(createBusyCheckbox(i, tabIndex++), 3, i+1);
            }
            tableLayoutPanel1.Dock = DockStyle.Fill;

            return tableLayoutPanel1;
        }

        private Label createLabel(int i, string name)
        {
            this.labels = new Label();
            this.labels.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labels.Name = "label"+i;
            this.labels.Size = new Size(718, 29);
            this.labels.Text = name;
            this.labels.TextAlign = ContentAlignment.MiddleCenter;
            return labels;
        }

        private CheckBox createOpenHourCheckboxes(int i, int tabIndex)
        {
            checkBox1 = new CheckBox();
            this.checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Name = "checkBox" + i;
            if (openHours[i]) { this.checkBox1.CheckState = CheckState.Checked; this.checkBox1.Checked = true;  }
            this.checkBox1.Size = new Size(718, 29);
            this.checkBox1.TabIndex = tabIndex;
            this.checkBox1.Text = convertTime(i);
            this.checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Dock = DockStyle.Fill;
            this.checkBox1.CheckedChanged += new EventHandler(checkBox_valueChanged);
            return checkBox1;
        }

        private void checkBox_valueChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int i = int.Parse(checkBox.Name.Substring(8));
            if (checkBox.Checked) openHours[i] = true;
            else openHours[i] = false;
        }

        private NumericUpDown createMinNumericUpDown(int i, int tabIndex)
        {
            minNumericUpDown = new NumericUpDown();
            this.minNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.minNumericUpDown.Name = "max" + i; //if you change name, change the i in valueChanged too.
            this.minNumericUpDown.Size = new Size(139, 30);
            this.minNumericUpDown.TabIndex = tabIndex;
            this.minNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.minNumericUpDown.Value = defaultMinWorker;
            this.minNumericUpDown.Maximum = defaultMaxWorker;
            this.minNumericUpDown.Dock = DockStyle.Fill;
            this.minNumericUpDown.ValueChanged += new EventHandler(this.minNumericUpDown_valueChanged);
            return minNumericUpDown;
        }

        private void minNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int i = int.Parse(numericUpDown.Name.Substring(3));
            minWorker[i] = Convert.ToInt32(numericUpDown.Value);
        }

        private NumericUpDown createMaxNumericUpDown(int i, int tabIndex)
        {
            maxNumericUpDown = new NumericUpDown();
            this.maxNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maxNumericUpDown.Name = "max" + i;
            this.maxNumericUpDown.Size = new Size(139, 30);
            this.maxNumericUpDown.TabIndex = tabIndex;
            this.maxNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.maxNumericUpDown.Dock = DockStyle.Fill;
            this.maxNumericUpDown.Value = defaultMaxWorker;
            this.maxNumericUpDown.Maximum = defaultMaxWorker;
            this.maxNumericUpDown.ValueChanged += new EventHandler(this.maxNumericUpDown_valueChanged);
            return maxNumericUpDown;
        }

        private void maxNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int i = int.Parse(numeric.Name.Substring(3));
            maxWorker[i] = Convert.ToInt32(numeric.Value);

        }

        private CheckBox createBusyCheckbox(int i, int tabIndex)
        {
            checkBox2 = new CheckBox();
            this.checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            this.checkBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Name = "busyCheckBox" + i;
            if (busyShifts[i]) { checkBox2.CheckState = CheckState.Checked; }
            this.checkBox2.Size = new Size(50, 27);
            this.checkBox2.TabIndex = tabIndex;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Dock = DockStyle.Fill;
            this.checkBox2.CheckedChanged += new EventHandler(checkBox2_valueChanged);
            return checkBox2;
        }

        private void checkBox2_valueChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int i = int.Parse(checkBox.Name.Substring(12));
            if (checkBox.Checked) busyShifts[i] = true;
            else busyShifts[i] = false; 
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00pm - " + convertTimeS(i+1);
            else if (i < 12) return i + ":00am - " + convertTimeS(i+1);
            else return i + ":00pm - " + convertTimeS(i+1);
        }

        private string convertTimeS(int i)
        {
            if (i > 12) return i - 12 + ":00pm";
            else if (i < 12) return i + ":00am";
            else return i + ":00pm";
        }


        public Day getDay()
        {
            return new Day(openHours, minWorker, maxWorker, busyShifts);
        }

        private void Control_Load_1(object sender, EventArgs e)
        {

        }

        public void invertOpenHours()
        {
            for(int i = 0; i < 24; i++)
            {
                openHours[i] = !openHours[i];
            }
        }
    }
}
