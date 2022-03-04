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
    public partial class Control : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private NumericUpDown minNumericUpDown;
        private NumericUpDown maxNumericUpDown;
        private CheckBox checkBox2;
        public int[] minWorker = new int[24];
        public int[] maxWorker = new int[24];
        public bool[] openHours = new bool[24];
        public int[] busyShifts = new int[24];
        public string[][] settings = new string[24][];

        public Control()
        {
            InitializeComponent();
            this.Controls.Add(loadShiftControls());
            for(int i = 0; i < 24; i++)
            {
                settings[i] = new string[3];
            }

        }

        private void Control_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
        }

        private TableLayoutPanel loadShiftControls()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel1.Location = new Point(54, 49);
            this.tableLayoutPanel1.Size = new Size(800, 950);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.AutoScroll = false;
            this.tableLayoutPanel1.ColumnCount = 4;
            //this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.09454F));
            //this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.90546F));
            //this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            //this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            int tabIndex = 0;
            for (int i = 0; i < 24; i++)
            {
                this.tableLayoutPanel1.Controls.Add(createOpenHourCheckboxes(i, tabIndex), 0, i);
                this.tableLayoutPanel1.Controls.Add(createMinNumericUpDown(i, tabIndex++), 1, i);
                this.tableLayoutPanel1.Controls.Add(createMaxNumericUpDown(i, tabIndex++), 2, i);
                this.tableLayoutPanel1.Controls.Add(createBusyCheckbox(i, tabIndex++), 3, i);
            }

            return tableLayoutPanel1;
        }

        private CheckBox createOpenHourCheckboxes(int i, int tabIndex)
        {
            checkBox1 = new CheckBox();
            this.checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Name = "checkBox" + i;
            this.checkBox1.Size = new Size(518, 29);
            this.checkBox1.TabIndex = tabIndex;
            this.checkBox1.Text = convertTime(i);
            this.checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.minNumericUpDown.Name = "max" + i; //if you change name, change the i in value changed too.
            this.minNumericUpDown.Size = new Size(139, 30);
            this.minNumericUpDown.TabIndex = tabIndex;
            this.minNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.minNumericUpDown.ValueChanged += new EventHandler(this.minNumericUpDown_valueChanged);
            return minNumericUpDown;
        }

        private void minNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int i = int.Parse(numericUpDown.Name.Substring(3));
            minWorker[i] = Convert.ToInt32(numericUpDown.Value);
            settings[i][0] = Convert.ToString(numericUpDown.Value); 
        }

        private NumericUpDown createMaxNumericUpDown(int i, int tabIndex)
        {
            maxNumericUpDown = new NumericUpDown();
            this.maxNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maxNumericUpDown.Name = "max" + i;
            this.maxNumericUpDown.Size = new Size(139, 30);
            this.maxNumericUpDown.TabIndex = tabIndex;
            this.maxNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.maxNumericUpDown.ValueChanged += new EventHandler(this.maxNumericUpDown_valueChanged);
            return maxNumericUpDown;
        }

        private void maxNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int i = int.Parse(numeric.Name.Substring(3));
            maxWorker[i] = Convert.ToInt32(numeric.Value);
            settings[i][1] = Convert.ToString(numeric.Value);

        }

        private CheckBox createBusyCheckbox(int i, int tabIndex)
        {
            checkBox2 = new CheckBox();
            this.checkBox2.CheckAlign = ContentAlignment.MiddleCenter;
            this.checkBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Name = "busyCheckBox" + i;
            this.checkBox2.Size = new Size(50, 27);
            this.checkBox2.TabIndex = tabIndex;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new EventHandler(checkBox2_valueChanged);
            return checkBox2;
        }

        private void checkBox2_valueChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int i = int.Parse(checkBox.Name.Substring(12));
            if (checkBox.Checked) settings[i][2] = "true";
            else settings[i][2] = "false"; 
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00pm - " + (i + 1) + ":00pm";
            else if (i < 12) return i + ":00am - " + (i + 1) + ":00am";
            else return i + ":00pm - " + (i + 1) + ":00pm";
        }

        public string[][] getSettings()
        {
            //return new Day(openHours, settings);
            return settings;
        }
    }
}
