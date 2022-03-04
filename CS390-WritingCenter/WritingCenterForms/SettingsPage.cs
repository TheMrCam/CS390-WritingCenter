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
    public partial class SettingsPage : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private NumericUpDown minNumericUpDown;
        private NumericUpDown maxNumericUpDown;
        private CheckBox checkBox2;
        public int[] minWorker = new int[24];
        public int[] maxWorker = new int[24];
        public int[] openHours = new int[24];
        public int[] busyShifts = new int[24];

        public SettingsPage()
        {
            InitializeComponent();

            SundayTab.Controls.Add(loadShiftControls());
            SundayTab.BackColor = Color.Wheat;
            SundayTab.AutoScroll = true;
            MondayTab.Controls.Add(loadShiftControls());
            TuedayTab.BackColor = Color.Wheat;
            WednesdayTab.BackColor = Color.Wheat;
            ThursdayTab.BackColor = Color.Wheat;
            FridayTab.BackColor = Color.Wheat;
            SaturdayTab.BackColor = Color.Wheat;

            TuedayTab.Controls.Add(loadShiftControls());
            WednesdayTab.Controls.Add(loadShiftControls());
            ThursdayTab.Controls.Add(loadShiftControls());
            FridayTab.Controls.Add(loadShiftControls());
            SaturdayTab.Controls.Add(loadShiftControls());
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach(int i in minWorker)
            {
                listBox2.Items.Add(i);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void shiftControls1_Load(object sender, EventArgs e)
        {

        }

        private TableLayoutPanel loadShiftControls()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            this.tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new Point(54, 49);
            this.tableLayoutPanel1.Size = new Size(SundayTab.Width, 950);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.AutoScroll = false;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.09454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.90546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            int tabIndex = 0;
            for(int i = 0; i < 24; i++)
            {
                this.tableLayoutPanel1.Controls.Add(createOpenHourCheckboxes(i, tabIndex++), 0, i);
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
            this.checkBox1.Size = new Size(418, 29);
            this.checkBox1.TabIndex = tabIndex;
            this.checkBox1.Text = convertTime(i);
            this.checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new EventHandler(checkBox_valueChanged);
            return checkBox1;
        }

        private void checkBox_valueChanged(object sender, EventArgs e)
        {
            int i = int.Parse(checkBox1.Name.Substring(checkBox1.Name.Length - 1));
            if (checkBox1.Checked) openHours[i] = 1;
            else openHours[i] = 0;
        }

        private NumericUpDown createMinNumericUpDown(int i, int tabIndex)
        {
            minNumericUpDown = new NumericUpDown();
            this.minNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.minNumericUpDown.Name = "minNumericUpDown" + i;
            this.minNumericUpDown.Size = new Size(139, 30);
            this.minNumericUpDown.TabIndex = tabIndex;
            this.minNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.minNumericUpDown.ValueChanged += new EventHandler(this.minNumericUpDown_valueChanged);
            return minNumericUpDown;
        }

        private void minNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            int i = int.Parse(minNumericUpDown.Name.Substring(maxNumericUpDown.Name.Length - 1));
            minWorker[i] = i;//Convert.ToInt32();
        }

        private NumericUpDown createMaxNumericUpDown(int i, int tabIndex)
        {
            maxNumericUpDown = new NumericUpDown();
            this.maxNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.maxNumericUpDown.Name = "maxNumericUpDown" + i;
            this.maxNumericUpDown.Size = new Size(139, 30);
            this.maxNumericUpDown.TabIndex = tabIndex;
            this.maxNumericUpDown.TextAlign = HorizontalAlignment.Center;
            this.maxNumericUpDown.ValueChanged += new EventHandler(this.maxNumericUpDown_valueChanged);
            return maxNumericUpDown;
        }

        private void maxNumericUpDown_valueChanged(object sender, EventArgs e)
        {
            int i = int.Parse(maxNumericUpDown.Name.Substring(maxNumericUpDown.Name.Length - 1));
            maxWorker[i] = Convert.ToInt32(maxNumericUpDown.Value);
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
            int i = int.Parse(checkBox2.Name.Substring(checkBox2.Name.Length - 1));
            if (checkBox2.Checked) openHours[i] = 1;
            else openHours[i] = 0;
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00pm - " + (i+1) + ":00pm";
            else if (i < 12) return i + ":00am - " + (i + 1) + ":00am";
            else return i + ":00pm - " + (i + 1) + ":00pm";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TuedayTab_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void SaturdayTab_Click(object sender, EventArgs e)
        {

        }
    }
}
