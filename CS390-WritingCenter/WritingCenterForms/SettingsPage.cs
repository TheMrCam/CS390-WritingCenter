using System;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class SettingsPage : UserControl
    {
        Day[] days = new Day[7];
        private scheduleView scheduleView;
        public SettingsPage(scheduleView scheduleView)
        {
            InitializeComponent();
            this.scheduleView = scheduleView;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void TuedayTab_Click(object sender, EventArgs e)
        {

        }

        private void SaturdayTab_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            days[0] = sundayControl.getDay();
            days[1] = mondayControl.getDay();
            days[2] = tuesdayControl.getDay();
            days[3] = wednesdayControl.getDay();
            days[4] = thursdayControl.getDay();
            days[5] = fridayControl.getDay();
            days[6] = saturdayControl.getDay();
            //scheduleView.setDays(days);
            this.Hide();
            scheduleView.Show();
            scheduleView.BringToFront();
        }
    }
}
