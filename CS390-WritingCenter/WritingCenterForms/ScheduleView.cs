using System;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class scheduleView : UserControl
    {
        private Schedule schedule;
        private FlowLayoutPanel sPanel;
        public scheduleView()
        {
            InitializeComponent();
            schedule = new Schedule();
            sPanel = new FlowLayoutPanel();
            
            prepareSchedule();
        }

        private void prepareSchedule()
        {
            //creating a panel to create all the labels in
            sPanel.Location = new System.Drawing.Point(60, 120);
            sPanel.Size = new System.Drawing.Size(800, 470);
            sPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            int cellHeight = 70;
            int cellWidth = 90;

            for (int i = 8; i < 23; i++)
            {
                createTimeLabels(cellHeight, cellWidth, i);
                for (int j = 0; j < 7; j++)
                {
                    createListBoxes(cellHeight, cellWidth, i, j);
                }
            }
            //Adding scroll bar to the panel
            sPanel.AutoScroll = true;
            this.Controls.Add(sPanel);
        }

        private void createTimeLabels(int height, int width, int time)
        {
            Label label = new Label();
            label.BackColor = System.Drawing.SystemColors.Info;
            label.Height = height;
            label.Width = width;
            label.Left = time * (width + 1); //makes a new label adjacent to the current label
            label.Name = "label" + time;
            label.Text = convertTime(time);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            sPanel.Controls.Add(label);
        }

        private void createListBoxes(int height, int width, int time, int day)
        {
            //making new labels
            ListBox lbox = new ListBox();
            //Button lbox = new Button();
            lbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbox.Height = height;
            lbox.Width = width;
            lbox.Left = time * (width + 1); //makes a new lbox adjacent to the current lbox
            lbox.Name = "lbox" + time + day;
            lbox.SelectionMode = SelectionMode.None;

            //adds every worker that is in that shift to the listbox
            foreach (string worker in schedule.getWorkers(time, day))
            {
                if (worker == "--") //if schedule is empty then create a empty box
                {
                    lbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    break;
                }
                else
                {
                    lbox.Items.Add(worker.Trim().Trim('\"'));
                    //lbox.Text += worker.Trim().Trim('\"') + "\n";
                }
            }

            //((scheduleArray[i, j] == "--") ? (Action)(() => { lbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText; })
            //                            : () => { lbox.Text = scheduleArray[i, j]; })();
            sPanel.Controls.Add(lbox);
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
            // add additional control to log user out
        }

        private void scheduleView_Load(object sender, EventArgs e)
        {

        }
    }
}
