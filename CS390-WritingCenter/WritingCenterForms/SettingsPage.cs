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
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        public SettingsPage()
        {
            InitializeComponent();

            //SundayTab.Controls.Add(loadShiftControls());
            //MondayTab.Controls.Add(loadShiftControls());
            //TuedayTab.Controls.Add(loadShiftControls());
            //WednesdayTab.Controls.Add(loadShiftControls());
            //ThursdayTab.Controls.Add(loadShiftControls());
            //FridayTab.Controls.Add(loadShiftControls());
            //SaturdayTab.Controls.Add(loadShiftControls());
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.tableLayoutPanel1.Location = new Point(0, 60);
            this.tableLayoutPanel1.Size = SundayTab.Size;
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.AutoScroll = true;
            int tabIndex = 0;
            for(int i = 0; i < 24; i++)
            {
                this.tableLayoutPanel1.Controls.Add(createOpenHourCheckboxes(i, tabIndex++), 0, i);
                this.tableLayoutPanel1.Controls.Add(createNumericUpDown(i, tabIndex++), 1, i);
                this.tableLayoutPanel1.Controls.Add(createNumericUpDown(i, tabIndex++), 2, i);
                this.tableLayoutPanel1.Controls.Add(createBusyCheckbox(i, tabIndex++), 3, i);
            }
            return tableLayoutPanel1;
        }

        private CheckBox createOpenHourCheckboxes(int i, int tabIndex)
        {
            checkBox1 = new CheckBox();
            this.checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Name = "checkBox" + i;
            this.checkBox1.Size = new Size(618, 29);
            this.checkBox1.TabIndex = tabIndex;
            this.checkBox1.Text = convertTime(i);
            this.checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            return checkBox1;
        }

        private NumericUpDown createNumericUpDown(int i, int tabIndex)
        {
            numericUpDown1 = new NumericUpDown();
            this.numericUpDown1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new Point(791, 3);
            this.numericUpDown1.Name = "numericUpDown2";
            this.numericUpDown1.Size = new Size(139, 30);
            this.numericUpDown1.TabIndex = tabIndex;
            this.numericUpDown1.TextAlign = HorizontalAlignment.Center;
            return numericUpDown1;
        }

        private CheckBox createBusyCheckbox(int i, int tabIndex)
        {
            checkBox2 = new CheckBox();
            this.checkBox2.CheckAlign = ContentAlignment.MiddleCenter;
            this.checkBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Name = "busyCheckBox" + i;
            this.checkBox2.Size = new Size(131, 27);
            this.checkBox2.TabIndex = tabIndex;
            this.checkBox2.UseVisualStyleBackColor = true;
            return checkBox2;
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00pm - " + (i+1) + ":00pm";
            else if (i < 12) return i + ":00am" + (i + 1) + ":00am";
            else return i + ":00pm" + (i + 1) + ":00pm";
        }
    }
}
