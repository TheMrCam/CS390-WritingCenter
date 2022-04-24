using System;
using System.Collections.Generic;
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
    //**************************************************************************
    // Creates new settings editor page
    //**************************************************************************
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
        //**************************************************************************
        // User Actions 
        //**************************************************************************
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

        private void submitButton_Click(object sender, EventArgs e)
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

            this.Hide();
            scheduleView.Show();
            scheduleView.BringToFront();
        }

        //
        // Sets all min workers on the schedule
        //

        private void setMinWorkersButton_Click(object sender, EventArgs e)
        {
            sundayControl.defaultMinWorker = (int)univMinWorkers.Value;
            mondayControl.defaultMinWorker = (int)univMinWorkers.Value;
            tuesdayControl.defaultMinWorker= (int)univMinWorkers.Value;
            wednesdayControl.defaultMinWorker = (int)univMinWorkers.Value;
            thursdayControl.defaultMinWorker = (int)univMinWorkers.Value;
            fridayControl.defaultMinWorker = (int)univMinWorkers.Value;
            saturdayControl.defaultMinWorker = (int)univMinWorkers.Value;

            reloadAllConPanels();
        }

        //
        // Sets all max workers on the schedule
        //

        private void setMaxWorkersButton_Click(object sender, EventArgs e)
        {
            sundayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            mondayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            tuesdayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            wednesdayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            thursdayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            fridayControl.defaultMaxWorker = (int)univMaxWorker.Value;
            saturdayControl.defaultMaxWorker = (int)univMaxWorker.Value;

            
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

    }
}
