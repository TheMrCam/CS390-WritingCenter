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
            FlowLayoutPanel sPanel = new FlowLayoutPanel();
            sPanel.Location = new System.Drawing.Point(75, 103);
            sPanel.Size = new System.Drawing.Size(470, 340);
            sPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;

            for (int i = 7; i < 23; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Label label = new Label();
                    label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    label.Height = 23;
                    label.Width = 82;
                    label.Left = i * (label.Width + 1);
                    label.Top = i * (label.Height - 1);
                    label.Name = "label" + i+j;
                    if (scheduleArray[i,j] == "--")
                    {
                        label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    } else
                    {
                        label.Text = scheduleArray[i, j];
                    }

                    sPanel.Controls.Add(label);
                }
            }
            this.Controls.Add(sPanel);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
