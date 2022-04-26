using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

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

        Dictionary<string,int> daysEnum = new Dictionary<string, int>(){
                { "sunday", 0},
                { "monday", 1},
                { "tuesday", 2},
                { "wednesday", 3},
                { "thursday", 4},
                { "friday", 5},
                { "saturday", 6}
            };

        //
        //*********************************************************************************************************
        // Creates new settings editor page
        //*********************************************************************************************************
        //
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
        }

        //
        //*********************************************************************************************************
        // User Actions 
        //*********************************************************************************************************
        //

        //
        // Double clicking on items in the left box will move them into the right (ordered) box
        //
        private void unorderedBox_Click(object sender, MouseEventArgs e)
        {
            orderedBox.Items.Add(unorderedBox.SelectedItem);
            unorderedBox.Items.Remove(unorderedBox.SelectedItem);
        }

        //
        // Resets ordering boxes
        //
        private void resetButton_Click(object sender, EventArgs e)
        {
            unorderedBox.Items.AddRange(orderedBox.Items);
            orderedBox.Items.Clear();
        }

        //
        // Clicking submit button will save all settings changed on the page
        //

        private async void submitButton_Click(object sender, EventArgs e)
        {
                                                                                // Creating days from tabs on panel
            days[0] = sundayControl.getDay();
            days[1] = mondayControl.getDay();
            days[2] = tuesdayControl.getDay();
            days[3] = wednesdayControl.getDay();
            days[4] = thursdayControl.getDay();
            days[5] = fridayControl.getDay();
            days[6] = saturdayControl.getDay();
            scheduleView.setDays(days);

            scheduleView.setMaxShiftsInRow((int)this.numShiftsAllowed.Value);


            ListBox.ObjectCollection priority = orderedBox.Items;               // Retrieves items ordered in priority
            List<string> settings = new List<string>();                         
            
            foreach(string i in priority) {  settings.Add(i);  }                // Turns into list of strings


            scheduleView.setSettings(settings);                                 // Sets

            bool highLow = false;
            if (highLowBox.CheckedItems.Contains("high")){ highLow = true; }
            scheduleView.setHighReqHrs(highLow);
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
                        await Task.Run(() => File.WriteAllText(fileName, this.exportCSV()));
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

            //this.Hide();
            //scheduleView.Show();
            //scheduleView.BringToFront();
        }

        //
        // Sets all min workers on the schedule
        //

        private void setMinWorkersButton_Click(object sender, EventArgs e)
        {
            sundayControl.setMinWorkerValues((int)univMinWorkers.Value);
            mondayControl.setMinWorkerValues((int)univMinWorkers.Value);
            tuesdayControl.setMinWorkerValues((int)univMinWorkers.Value);
            wednesdayControl.setMinWorkerValues((int)univMinWorkers.Value);
            thursdayControl.setMinWorkerValues((int)univMinWorkers.Value);
            fridayControl.setMinWorkerValues((int)univMinWorkers.Value);
            saturdayControl.setMinWorkerValues((int)univMinWorkers.Value);
            reloadAllConPanels();
        }

        //
        // Sets all max workers on the schedule
        //

        private void setMaxWorkersButton_Click(object sender, EventArgs e)
        {

            sundayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            mondayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            tuesdayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            wednesdayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            thursdayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            fridayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            saturdayControl.setMaxWorkerValues((int)univMaxWorker.Value);
            reloadAllConPanels();
        }

        //
        // Inverts current selection for open hours based on idex chosen in the combo box
        //

        private void invertOpenHrs_Click(object sender, EventArgs e)
        {
            if(tabComboBox.SelectedIndex.Equals(daysEnum["sunday"])) { sundayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["monday"])) { mondayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["tuesday"])) { tuesdayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["wednesday"])) { wednesdayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["thursday"])) { thursdayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["friday"])) { fridayControl.invertOpenHours(); }
            else if(tabComboBox.SelectedIndex.Equals(daysEnum["saturday"])) { saturdayControl.invertOpenHours(); }
            
            reloadAllConPanels();
        }

        //
        // Reloads all shift control panels to reflect updates from buttons
        //

        private void reloadAllConPanels()
        {
            sundayControl.Controls.Add(sundayControl.loadShiftControls());
            mondayControl.Controls.Add(mondayControl.loadShiftControls());
            tuesdayControl.Controls.Add(tuesdayControl.loadShiftControls());
            wednesdayControl.Controls.Add(wednesdayControl.loadShiftControls());
            thursdayControl.Controls.Add(thursdayControl.loadShiftControls());
            fridayControl.Controls.Add(fridayControl.loadShiftControls());
            saturdayControl.Controls.Add(saturdayControl.loadShiftControls());
        }

        public string exportCSV()
        {
            string delimiter = ",";
            string file = "OrderBox" + delimiter + "[";
            foreach (string s in orderedBox.Items)
            {
                file += s + '|';
            }
            file = file.Substring(file.Length-1);
            file += "]" + "\n";
            file += "Consecutive Shifts" + delimiter + numShiftsAllowed.Value + "\n";
            file += "High or Low" + delimiter;
            for (int i = 0; i <= (highLowBox.Items.Count - 1); i++)
            {
                if (highLowBox.GetItemChecked(i))
                {
                    file += "Item " + (i + 1).ToString() + " = " + highLowBox.Items[i].ToString() + "\n";
                }
            }
            file += "Max Workers" + delimiter + univMaxWorker.Value + "\n";
            file += "Min Workers" + delimiter + univMinWorkers.Value + "\n";
            file += sundayControl.getValues();
            file += mondayControl.getValues();
            file += tuesdayControl.getValues();
            file += wednesdayControl.getValues();
            file += thursdayControl.getValues();
            file += fridayControl.getValues();
            file += saturdayControl.getValues();

            return file;
        }

    }
}
