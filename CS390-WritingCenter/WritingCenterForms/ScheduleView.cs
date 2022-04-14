using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace WritingCenterForms
{
    public partial class scheduleView : UserControl, Observer
    {
        private Schedule schedule;
        private FlowLayoutPanel sPanel = new FlowLayoutPanel();
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        private AccountDatabase Accounts;
        private Observable obsv;
        private Button selectedButton;
        private int cellHeight;
        private int cellWidth;
        private int panelHeight;
        private int panelWidth;
        private Alert alert;

        public AccountDatabase GetAccountDatabase() { return Accounts; }

        public List<string> getSettings()
        { return schedule.settings; }

        public void setSettings(List<string> settings)
            { schedule.settings = settings; }


        public scheduleView(AccountDatabase Accounts) // version for the admin page
        {
            InitializeComponent();
            cellHeight = 80;
            cellWidth = 105;
            panelHeight = 510;
            panelWidth = 800;
            this.Accounts = Accounts;
            schedule = new Schedule(Accounts, this);
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.Anchor = AnchorStyles.Top |  AnchorStyles.Left;
            this.Dock = DockStyle.Fill;
            loadSchedule();
        }

        public scheduleView() // version for consultant page
        {
            InitializeComponent();
            schedule = new Schedule(this);
            cellHeight = 80;
            cellWidth = 105;
            panelHeight = 510;
            panelWidth = 800;
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;
            loadSchedule();
        }

        public void loadSchedule()
        {
            if (tableLayoutPanel.HasChildren) { tableLayoutPanel.Controls.Clear(); } // if there is stuff in the current panel, removes everything

            this.tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.Size = new Size(panelWidth, panelHeight);
            this.tableLayoutPanel.RowCount = 25;
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 8;
            tableLayoutPanel.Location = new Point(0, 76);
            tableLayoutPanel.BackColor = SystemColors.ActiveCaption;
            
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));

            for (int i = 0; i < 24; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 120F));
            }

            tableLayoutPanel.Controls.Add(createDayLabels("Sunday"), 1, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Monday"), 2, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Tuesday"), 3, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Wednesday"), 4, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Thursday"), 5, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Friday"), 6, 0);
            tableLayoutPanel.Controls.Add(createDayLabels("Saturday"), 7, 0);

            for (int i = 0; i < 24; i++)
            {
                tableLayoutPanel.Controls.Add(createTimeLabels(i), 0, i+1);
                for (int j = 0; j < 7; j++)
                {
                    tableLayoutPanel.Controls.Add(createButtons(i, j), j+1, i+1);
                }
            }
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(tableLayoutPanel);
        }

        private Label createTimeLabels(int time)
        {
            Label label = new Label();
            label.BackColor = System.Drawing.SystemColors.Info;
            label.Height = cellHeight;
            label.Width = cellWidth;
            label.Left = time * ((int)cellWidth + 1); //makes a new label adjacent to the current label
            label.Name = "label" + time;
            label.Text = convertTime(time);
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            return label;
        }

        private Label createDayLabels(string day)
        {
            Label label = new Label();
            label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label.Height = cellHeight;
            label.Width = cellWidth;
            label.Text = day;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label.Dock= DockStyle.Fill;
            return label;
        }

        private Button createButtons(int time, int day)
        {
            //making new buttons
            Button lbox = new Button();
            lbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbox.Height = cellHeight;
            lbox.Width = cellWidth;
            lbox.Left = time * ((int)cellWidth + 1); //makes a new lbox adjacent to the current lbox
            lbox.Name = "lbox" + day + time; //if you change the lbox change the number in scheduleV
            lbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            lbox.FlatStyle = FlatStyle.Flat;
            lbox.Dock = DockStyle.Fill;
            //lbox.SelectionMode = SelectionMode.None;
            //adds every worker that is in that shift to the listbox
            displayWorkers(lbox, time, day);
            lbox.Click += new EventHandler(this.lbox_editShift);
            //sPanel.Controls.Add(lbox);
            return lbox;
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
            displayWorkers(selectedButton, time ,day);
        }
        private void displayWorkers(Button lbox, int time, int day)
        {
            string[] workers = schedule.getWorkers(time, day);
            if (workers != null)
            {
                workers = workers.Where(x => x != "\n").ToArray();
                lbox.BackColor = Color.White;
                foreach (string worker in workers)
                {
                    //lbox.Items.Add(worker.Trim().Trim('\"'));
                    lbox.Text += worker.Trim().Trim('\"') + "\n";
                }
                if (workers.Length <= 2) 
                {
                    lbox.FlatAppearance.BorderColor = Color.IndianRed;
                    lbox.FlatAppearance.BorderSize = 3;
                }
                else if (workers.Length <= 3)
                {
                    lbox.FlatAppearance.BorderColor = Color.SandyBrown;
                    lbox.FlatAppearance.BorderSize = 3;
                }
                else
                {
                    lbox.FlatAppearance.BorderColor = Color.Black;
                    lbox.FlatAppearance.BorderSize = 0;
                }
            }
            else lbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            //if (lbox.Text.Length > 60)
            //{
            //    int row = int.Parse(lbox.Name.Substring(5));
            //    tableLayoutPanel.RowStyles[row].Height = 200;
            //}
        }

        private string convertTime(int i)
        {
            if (i > 12) return i - 12 + ":00 PM";
            else if (i < 12) return i + ":00 AM";
            else return i + ":00 PM";
        }

        private void scheduleView_Load(object sender, EventArgs e)
        {
            //prepareSchedule();
            //loadSchedule();
        }

        private async void ExportSchedule_Click(object sender, EventArgs e)
        {
            string fileName;
            DialogResult result;
            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.Title = "Save Database to file";
                fileChooser.Filter = "CSV Database|*.csv|Plain Text|*.txt";
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
            try { schedule.buildSchedule(schedule.maxShiftInRow); }
            catch { MessageBox.Show("Issue generating new schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try
            {
                updateSView();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateSView()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    int day = int.Parse(button.Name.Substring(4, 1));
                    int time = int.Parse(button.Name.Substring(5));
                    button.Text = "";
                    displayWorkers(button, time, day);
                }
            }
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

        public void createAlert(string[] workers)
        {
            alert = new Alert();
            alert.updateAlertBox(workers);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public int getMaxShiftsInRow() { return schedule.maxShiftInRow; }
        public void setMaxShiftsInRow(int msir) { schedule.maxShiftInRow = msir; }
        public void setHighReqHrs(bool high) { schedule.highReqHrs = high; }
    }
}
