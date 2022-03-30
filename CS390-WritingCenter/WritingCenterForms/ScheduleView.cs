using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;

namespace WritingCenterForms
{
    public partial class scheduleView : UserControl, Observer
    {
        private Schedule schedule;
        private FlowLayoutPanel sPanel = new FlowLayoutPanel();
        private AccountDatabase Accounts;
        private Observable obsv;
        private Button selectedButton;
        private int cellHeight;
        private int cellWidth;
        private int panelHeight;
        private int panelWidth;

        public AccountDatabase GetAccountDatabase() { return Accounts; }
        public scheduleView(AccountDatabase Accounts) // version for the admin page
        {
            InitializeComponent();
            cellHeight = 70;
            cellWidth = 90;
            panelHeight = 455;
            panelWidth = 800;
            this.Accounts = Accounts;
            schedule = new Schedule(Accounts, this);
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Anchor = AnchorStyles.Top |  AnchorStyles.Left;
            this.Dock = DockStyle.Fill;
            prepareSchedule();
        }

        public scheduleView() // version for consultant page
        {
            InitializeComponent();
            schedule = new Schedule(this);
            cellHeight = 70;
            cellWidth = 90;
            panelHeight = 455;
            panelWidth = 800;
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            prepareSchedule();
        }

        public void prepareSchedule()
        {
            if (sPanel.HasChildren) { sPanel.Controls.Clear(); } // if there is stuff in the current panel, removes everything
            //creating a panel to create all the labels in
            sPanel.Location = new Point(10, 120);
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.BackColor = SystemColors.ActiveCaption;

            for (int i = 0; i < 24; i++)
            {
                createTimeLabels(i);
                for (int j = 0; j < 7; j++)
                {
                    createListBoxes(i, j);
                }
            }
            //Adding scroll bar to the panel
            sPanel.AutoScroll = true;
            this.Controls.Add(sPanel);
        }

        private void createTimeLabels(int time)
        {
            Label label = new Label();
            label.BackColor = System.Drawing.SystemColors.Info;
            label.Height = cellHeight;
            label.Width = cellWidth;
            label.Left = time * ((int)cellWidth + 1); //makes a new label adjacent to the current label
            label.Name = "label" + time;
            label.Text = convertTime(time);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            sPanel.Controls.Add(label);
        }

        private void createListBoxes(int time, int day)
        {
            //making new labels
            //ListBox lbox = new ListBox();
            Button lbox = new Button();
            lbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbox.Height = cellHeight;
            lbox.Width = cellWidth;
            lbox.Left = time * ((int)cellWidth + 1); //makes a new lbox adjacent to the current lbox
            lbox.Name = "lbox" + day + time; //if you change the lbox change the number in scheduleV
            lbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //lbox.SelectionMode = SelectionMode.None;

            //adds every worker that is in that shift to the listbox
            displayWorkers(lbox, time, day);
            lbox.Click += new EventHandler(this.lbox_editShift);
            sPanel.Controls.Add(lbox);
        }

        private void lbox_editShift(object sender, EventArgs e)
        {
            selectedButton = (Button)sender;
            EditShift edit = new EditShift(schedule, Accounts);
            int day = int.Parse(selectedButton.Name.Substring(4, 1));
            int time = int.Parse(selectedButton.Name.Substring(5));
            this.addObservable(edit);
            edit.add(this);
            edit.loadWorkers(selectedButton.Text, day, time);
            edit.Show();
            edit.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void displayWorkers(Button lbox, int time, int day)
        {
            string[] workers = schedule.getWorkers(time, day);
            if (workers != null)
            {
                foreach (string worker in workers)
                {
                    //lbox.Items.Add(worker.Trim().Trim('\"'));
                    lbox.Text += worker.Trim().Trim('\"') + "\n";
                }
            }
            else lbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00 PM";
            else if (i < 12) return i + ":00 AM";
            else return i + ":00 PM";
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            // add additional control to log user out
        }

        private void scheduleView_Load(object sender, EventArgs e)
        {
            prepareSchedule();
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
                        await Task.Run(() => File.WriteAllText(fileName, schedule.exportCSV()));  
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

        public void setDays(Day[] days)
        {
            this.schedule.setDays(days);
        }

        private void generateSchedule_Click(object sender, EventArgs e)
        {
            int N = 4; // we need to get the setting out of the settings page somehow
            try { schedule.buildSchedule(N); }
            catch { MessageBox.Show("Issue generating new schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            prepareSchedule();
        }

        public void addObservable(Observable observable)
        {
            obsv = observable;
        }

        public void update(int time, int day)
        {
            selectedButton.Text = "";
            displayWorkers(selectedButton, time, day);
        }

        private void scheduleView_SizeChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
            int heightDifference = sPanel.Height - panelHeight;
            int widthDifference = sPanel.Width - panelWidth;
            cellHeight = cellHeight + heightDifference;
            cellWidth = cellWidth + widthDifference;

            foreach(Label control in sPanel.Controls.OfType<Label>())
            {
                control.Size = new Size(cellWidth, cellHeight);
            }
            foreach (Button control in sPanel.Controls.OfType<Button>())
            {
                control.Size = new Size(cellWidth, cellHeight);
            }
        }
    }
}
