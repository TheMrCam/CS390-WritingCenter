using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class AcctManagePage : UserControl
    {
        EditAcctInfoPage EditAcctInfoPage1 = new EditAcctInfoPage();

        //
        //*********************************************************************************************************
        // Main Constructor
        //*********************************************************************************************************
        //
        public AcctManagePage()
        {
            InitializeComponent();

            this.Controls.Add(EditAcctInfoPage1);
            //this.refreshAccounts();
            AcctDisplayListBox.DrawMode = DrawMode.OwnerDrawFixed;
            AcctDisplayListBox.DrawItem += AcctDisplayListBox_DrawItem;
            refreshAccounts();
            EditAcctInfoPage1.Hide();
        }

        //
        //*********************************************************************************************************
        // Helper Func
        //*********************************************************************************************************
        //

        //
        // Draws the list box for the accounts, with an alternating color scheme
        //

        private void AcctDisplayListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                /* If the item is selected set the background color to SystemColors.Highlight 
                 or else set the color to either WhiteSmoke or White depending if the item index is even or odd */
                Color color = isSelected ? SystemColors.Highlight :
                    e.Index % 2 == 0 ? Color.WhiteSmoke : Color.White;

                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(color);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(AcctDisplayListBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        //
        // Refreshes the lines to display in the box
        //

        private void refreshAccounts()
        {
            AcctDisplayListBox.Items.Clear();
            string[] tempAcctList = WCSchedulerForm.Accounts.DisplayLines();
            /*foreach (string line in tempAcctList)
            {
                AcctDisplayListBox.Items.Add(line);
            }*/
            AcctDisplayListBox.Items.AddRange(tempAcctList);
        }

        //
        //*********************************************************************************************************
        // User Actions
        //*********************************************************************************************************
        //

        //
        // Occurs when user clicks "Upload CSV" button: pops up dialog to select file to upload,
        //      and provides popup feedback on success
        //

        private void uploadCSV_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new OpenFileDialog())
            {
                fileChooser.Title = "Import database from file";
                fileChooser.Filter = "CSV Database|*.csv";
                //fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        WCSchedulerForm.Accounts.ImportFromCSV(fileName);
                        MessageBox.Show($"Successfully imported database from {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //
        // Occurs when user clicks "Add Account" button, opens blank account editor page
        //

        private void manualEntry_Click(object sender, EventArgs e)
        {
            EditAcctInfoPage1.Show();
            EditAcctInfoPage1.BringToFront();
        }

        //
        // Occurrs when user clicks "Refresh" button, calls refresh database
        //

        private void refreshDatabase_click(object sender, EventArgs e)
        {
            refreshAccounts();
        }

        //
        // Occurs when user clicks "Clear DB" button, clears the database of all accounts
        //

        private void clearDBClick(object sender, EventArgs e)
        {
            WCSchedulerForm.Accounts.ClearDatabase();
        }

        //
        // Occurs when "Export CSV" button is clicked, prompts user to select a location to save the account DB
        //

        private void exportCSVButton_Click(object sender, EventArgs e)
        {

        }

        //
        // Occurs when "Select" button is clicked, opens the edit account screen populated with account information
        //

        private void AddAccountButton_Click(object sender, EventArgs e)
        {

        }

        //
        // Occurs when "Delete" button is clicked, removes the currently selected account from the database
        //

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
