using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class AcctManagePage : UserControl
    {
        EditAcctInfoPage EditAcctInfoPage1 = new EditAcctInfoPage();
        public AcctManagePage()
        {
            InitializeComponent();

            this.Controls.Add(EditAcctInfoPage1);
            this.refreshAccounts();

            EditAcctInfoPage1.Hide();
        }

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
                        MessageBox.Show($"Successfully imported database from {fileName}","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void refreshAccounts()
        {
            AcctDisplayListBox.Items.Clear();
            string[] tempAcctList = WCSchedulerForm.Accounts.DisplayLines();
            foreach (string line in tempAcctList)
            {
                AcctDisplayListBox.Items.Add(line);
            }
        }


        private void manualEntry_Click(object sender, EventArgs e)
        {
            EditAcctInfoPage1.Show();
            EditAcctInfoPage1.BringToFront();
        }

        private void refreshDatabase_click(object sender, EventArgs e)
        {
            refreshAccounts();
        }

        private void AcctDisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearDBClick(object sender, EventArgs e)
        {
            WCSchedulerForm.Accounts.ClearDatabase();
        }

        private void viewAcctsButton_Click(object sender, EventArgs e)
        {

        }

        private void exportCSVButton_Click(object sender, EventArgs e)
        {

        }
    }
}
