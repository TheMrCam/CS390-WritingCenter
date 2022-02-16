using System;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class scheduleView : UserControl
    {
        private Schedule schedule;
        private string[,] scheduleArray;
        public scheduleView()
        {
            InitializeComponent();
            schedule = new Schedule();
            scheduleArray = schedule.getSchedule();
            prepareSchedule();
        }

        private void prepareSchedule()
        {
            //creating a panel to create all the labels in
            FlowLayoutPanel sPanel = new FlowLayoutPanel();
            sPanel.Location = new System.Drawing.Point(75, 103);
            sPanel.Size = new System.Drawing.Size(625, 370);
            sPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;

            for (int i = 7; i < 23; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //making new labels
                    Label label = new Label();
                    label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    label.Height = 23;
                    label.Width = 83;
                    label.Left = i * (label.Width + 1); //makes a new label adjacent to the current label
                    //label.Top = i * (label.Height + 1);
                    label.Name = "label" + i+j;
                    //if (scheduleArray[i,j] == "--") //if schedule is empty then create a empty box
                    //{
                    //    label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    //} else
                    //{
                    //    label.Text = scheduleArray[i, j];
                    //}
                    ((scheduleArray[i, j] == "--") ? (Action)(() => { label.BackColor = System.Drawing.SystemColors.ActiveCaptionText; })
                                                : () => { label.Text = scheduleArray[i, j]; })();
                    sPanel.Controls.Add(label);
                }
            }

            FlowLayoutPanel timePanel = new FlowLayoutPanel();
            timePanel.Location = new System.Drawing.Point(10, 103);
            timePanel.Size = new System.Drawing.Size(100, 370);
            timePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;

            for (int i = 8; i < 24; i++)
            {
                //making new labels
                Label label = new Label();
                label.BackColor = System.Drawing.SystemColors.Info;
                label.Height = 23;
                label.Width = 80;
                label.Left = i * (label.Width + 1); //makes a new label adjacent to the current label
                                                    //label.Top = i * (label.Height + 1);
                label.Name = "label" + i;
                label.Text = convertTime(i);
                timePanel.Controls.Add(label);
            }

            this.Controls.Add(sPanel);
            this.Controls.Add(timePanel);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string convertTime(int i)
        {
            return i > 12 ? i - 12 + ":00 PM": i+":00 AM";
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void scheduleView_Load(object sender, EventArgs e)
        {

        }
    }
}
