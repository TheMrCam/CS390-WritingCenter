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
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
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
            //panel1.Hide();
            //prepareSchedule();
            loadSchedule();
        }

        public scheduleView() // version for consultant page
        {
            InitializeComponent();
            schedule = new Schedule(this);
            cellHeight = 70;
            cellWidth = 105;
            panelHeight = 510;
            panelWidth = 800;
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //prepareSchedule();
            loadSchedule();
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
                    createButtons(i, j);
                }
            }
            //Adding scroll bar to the panel
            sPanel.AutoScroll = true;
            this.Controls.Add(sPanel);
        }

        public void loadSchedule()
        {
            if (tableLayoutPanel.HasChildren) { tableLayoutPanel.Controls.Clear(); } // if there is stuff in the current panel, removes everything

            this.tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.Size = new Size(panelWidth, panelHeight);
            this.tableLayoutPanel.RowCount = 25;
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 8;
            tableLayoutPanel.Location = new Point(5, 76);
            tableLayoutPanel.BackColor = SystemColors.ActiveCaption;
            
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));


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
            //tableLayoutPanel.Dock = DockStyle.Fill;
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
            label.Dock= DockStyle.Fill;
            return label;
        }

        private Button createButtons(int time, int day)
        {
            //making new buttons
            //ListBox lbox = new ListBox();
            Button lbox = new Button();
            lbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbox.Height = cellHeight;
            lbox.Width = cellWidth;
            lbox.Left = time * ((int)cellWidth + 1); //makes a new lbox adjacent to the current lbox
            lbox.Name = "lbox" + day + time; //if you change the lbox change the number in scheduleV
            lbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            //prepareSchedule();
            loadSchedule();
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

        public void sizeChanged(FormWindowState ws)
        {
            if (ws == FormWindowState.Maximized)
            {
                Sunday.Location = new Point(200, 104);
                Monday.Location = new Point(400, 104);
                Tuesday.Location = new Point(600, 104);
                Wednesday.Location = new Point(800, 104);
                Thursday.Location = new Point(900, 104);
                Friday.Location = new Point(1000, 104);
                Saturday.Location = new Point(1200, 104);
                foreach (Label label in sPanel.Controls.OfType<Label>())
                {
                    label.Size = new Size(110, 90);
                }
                foreach (Button button in sPanel.Controls.OfType<Button>())
                {
                    button.Size = new Size(200, 90);
                    button.Font = new Font("Microsoft Sans Serif", 10);
                }
            }
            else
            {
                //Sunday.Location = new Point(157, 104);
                //Monday.Location = new Point(293, 104);
                //Tuesday.Location = new Point(412, 104);
                //Wednesday.Location = new Point(529, 104);
                //Thursday.Location = new Point(670, 104);
                //Friday.Location = new Point(811, 104);
                //Saturday.Location = new Point(926, 104);
                foreach (Label label in sPanel.Controls.OfType<Label>())
                {
                    label.Size = new Size(90, 70);
                }
                foreach (Button button in sPanel.Controls.OfType<Button>())
                {
                    button.Size = new Size(90, 70);
                }
            }
        }
    }
}
