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


        public void setSettings(List<string> settings)
            { schedule.settings = settings; }


        public scheduleView(AccountDatabase Accounts) // version for the admin page
        {
            InitializeComponent();
            cellHeight = 80;
            cellWidth = 105;
            panelHeight = 660;
            panelWidth = 1055;
            this.Accounts = Accounts;
            schedule = new Schedule(Accounts, this);
            sPanel.Size = new Size(panelWidth, panelHeight);
            sPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.Anchor = AnchorStyles.Top |  AnchorStyles.Left;
            this.Dock = DockStyle.Fill;
            loadSchedule();
            loadLegend();
        }

        public void loadSchedule()
        {
            if (tableLayoutPanel.HasChildren) { tableLayoutPanel.Controls.Clear(); } // if there is stuff in the current panel, removes everything

            this.tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.Size = new Size(panelWidth, panelHeight);
            this.tableLayoutPanel.RowCount = 25;
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
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
                if (workers.Length <= 1) 
                {
                    lbox.FlatAppearance.BorderColor = Color.IndianRed;
                    lbox.FlatAppearance.BorderSize = 4;
                    lbox.BackColor = Color.FromArgb(244, 204, 204);
                    
                }
                else if (workers.Length <= 3)
                {
                    lbox.FlatAppearance.BorderColor = Color.SandyBrown;
                    lbox.FlatAppearance.BorderSize = 3;
                    lbox.BackColor = Color.FromArgb(252, 229, 205);
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
            //ToolTip tp = new ToolTip();
            //tp.ToolTipTitle = "Legend";
            //tp.UseFading = false;
            //tp.UseAnimation = true;
            //tp.IsBalloon = false;
            //tp.ShowAlways = true;
            ////tp.AutoPopDelay = 1000;
            ////tp.ReshowDelay = 0;
            //tp.SetToolTip(legendButton, "Red: Needs Workers \n Orange: Understaffed");
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
            try { 
                schedule.buildSchedule(schedule.maxShiftInRow);
                List<string> temp = schedule.settings;
                List<string> settingsNew = new List<string>();
                List<string> zeroHours = new List<string>();
                List<string> overHours = new List<string>();
                List<string> underHours = new List<string>();
                int ZeroStart = temp.IndexOf("ZERO");
                int UnderStart = temp.IndexOf("UNDER");
                int OverStart = temp.IndexOf("OVER");

                for (int i = 0; i <= temp.Count-1; i++)
                {
                    if (!i.Equals(ZeroStart) && !i.Equals(OverStart) && !i.Equals(UnderStart))
                    {
                        if (i < ZeroStart) { settingsNew.Add(temp[i]); }
                        else if (i < UnderStart) { zeroHours.Add(temp[i]); }
                        else if (i < OverStart) { underHours.Add(temp[i]); }
                        else { overHours.Add(temp[i]); }
                    }
                }

                schedule.settings = settingsNew;

                if (underHours.Count > 0 | overHours.Count > 0 | zeroHours.Count > 0)
                {
                    string[] underWorkers = listToString(underHours);
                    string[] overWorkers = listToString(overHours);
                    string[] notWorkers = listToString(zeroHours);
                    createAlert(underWorkers, overWorkers, notWorkers);
                }


            }
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

        public void createAlert(string[] underWorkers, string[] overWorkers, string[] notWorkers)
        {
            alert = new Alert();
            alert.updateAlertBox(underWorkers, overWorkers, notWorkers);
            alert.Show();
            alert.BringToFront();
        }

        public void setMaxShiftsInRow(int msir) { schedule.maxShiftInRow = msir; }
        public void setHighReqHrs(bool high) { schedule.highReqHrs = high; }

        private string[] listToString(List<string> list)
        {
            string[] newArray = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                newArray[i] = list[i];
            }
            return newArray;
        }

        private void loadLegend()
        {
            legendPanel.Size = new Size(300, 80);
            Button red = new Button();
            red.FlatAppearance.BorderColor = Color.IndianRed;
            red.FlatAppearance.BorderSize = 2;
            red.BackColor = Color.FromArgb(244, 204, 204);
            red.Text = "No Workers";
            red.Size = new Size(100, 50);
            red.Left = 130;
            red.Enabled = false;
            legendPanel.Controls.Add(red);

            Button orange = new Button();
            orange.FlatAppearance.BorderColor = Color.SandyBrown;
            orange.FlatAppearance.BorderSize = 2;
            orange.BackColor = Color.FromArgb(252, 229, 205);
            orange.Text = "Underscheduled";
            orange.Size = new Size(140, 50);
            orange.Enabled = false;
            legendPanel.Controls.Add(orange);
        }


    }
}
