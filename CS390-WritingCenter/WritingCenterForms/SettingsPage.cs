using System;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class SettingsPage : UserControl
    {
        Day[] days = new Day[7];
        private scheduleView scheduleView;
        private shiftControl sundayControl = new shiftControl();
        private shiftControl mondayControl = new shiftControl();
        private shiftControl tuesdayControl = new shiftControl();
        private shiftControl wednesdayControl = new shiftControl();
        private shiftControl thursdayControl = new shiftControl();
        private shiftControl fridayControl = new shiftControl();
        private shiftControl saturdayControl = new shiftControl();


        public SettingsPage(scheduleView scheduleView)
        {
            InitializeComponent();
            this.scheduleView = scheduleView;
            SundayTab.Controls.Add(sundayControl);
            MondayTab.Controls.Add(mondayControl);
            TuedayTab.Controls.Add(tuesdayControl);
            WednesdayTab.Controls.Add(wednesdayControl);
            ThursdayTab.Controls.Add(thursdayControl);
            FridayTab.Controls.Add(fridayControl);
            SaturdayTab.Controls.Add(saturdayControl);
            Console.WriteLine("SETTINGS PAGE ADDED");
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            orderedBox.Items.Add(unorderedBox.SelectedItem);
            unorderedBox.Items.Remove(unorderedBox.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unorderedBox.Items.AddRange(orderedBox.Items);
            orderedBox.Items.Clear();
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
            scheduleView.setDays(days);
            this.Hide();
            scheduleView.Show();
            scheduleView.BringToFront();
        }
    }
}
