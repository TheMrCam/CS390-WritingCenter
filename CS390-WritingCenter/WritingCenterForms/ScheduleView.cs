using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WritingCenterForms
{
    public partial class scheduleView : UserControl
    {
        private Schedule schedule;
        private FlowLayoutPanel sPanel;
        public scheduleView(AccountDatabase Accounts) // version for the admin page
        {
            InitializeComponent();
            schedule = new Schedule(Accounts);
            sPanel = new FlowLayoutPanel();
            
            prepareSchedule();
        }

        public scheduleView() // version for consultant page
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

            for (int i = 8; i < 24; i++)
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
            //ListBox lbox = new ListBox();
            Button lbox = new Button();
            lbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbox.Height = height;
            lbox.Width = width;
            lbox.Left = time * (width + 1); //makes a new lbox adjacent to the current lbox
            lbox.Name = "lbox" + time + day;
            //lbox.SelectionMode = SelectionMode.None;

            //adds every worker that is in that shift to the listbox
            string[] workers = schedule.getWorkers(time, day);
            if (workers != null)
            {
                foreach (string worker in schedule.getWorkers(time, day))
                {
                    //lbox.Items.Add(worker.Trim().Trim('\"'));
                    lbox.Text += worker.Trim().Trim('\"') + "\n";
                }
            } 
            else  lbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            sPanel.Controls.Add(lbox);
        }

        //public ArrayList getOpenHours()
        //{
        //    return schedule.getOpenHours();
        //}

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

        private async void ExportSchedule_Click(object sender, EventArgs e)
        {
            string fileName;
            DialogResult result;
            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.Title = "Save Database to file";
                fileChooser.Filter = "Plain Text|*.txt|CSV Database|*.csv";
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                //MessageBox.Show("Here1");
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show("Here2");
                    try
                    {
                        bool clean = fileName[fileName.IndexOf('.') + 1] != 'c';
                        await Task.Run(() => File.WriteAllLines(fileName, schedule.ScheduleLines()));  
                        //change Accounts.DatabaseLines above to Schedule export of string[]
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Miscellaneous Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
