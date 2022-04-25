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
    public partial class FirstSetup : Form
    {
        private string databaseFilePath = ConfigManager.DatabasePath;
        public FirstSetup()
        {
            InitializeComponent();
            if (databaseFilePath != "") { FileName_label.Text = databaseFilePath; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UploadCSV_button_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new OpenFileDialog())
            {
                fileChooser.Title = "Import database from CSV file";
                fileChooser.Filter = "CSV Database|*.csv";
                //fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                databaseFilePath = fileName;
                FileName_label.Text = databaseFilePath;
                /*if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        WCSchedulerForm.Accounts.ImportFromCSV(fileName);
                        MessageBox.Show($"Successfully imported database from {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FileName_label.Text = fileName;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Miscellaneous Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
            }
            
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (MasterUser_TextBox.Text == "" || MasterPassword_TextBox.Text == "" || DefaultPass_TextBox.Text == "" || databaseFilePath == "")
            {
                MessageBox.Show("Not all fields completed","Try Again",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ConfigManager.MasterUsername = MasterUser_TextBox.Text;
                ConfigManager.MasterPassword = MasterPassword_TextBox.Text;
                ConfigManager.DefaultUserPassword = DefaultPass_TextBox.Text;
                ConfigManager.DatabasePath = databaseFilePath;
                this.Close();
                /*try
                {
                    WCSchedulerForm.Accounts.ImportFromCSV(databaseFilePath);
                    //MessageBox.Show($"Successfully imported database from {databaseFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FileName_label.Text = databaseFilePath;
                    
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Miscellaneous Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { this.Close(); } */
            }
        }
    }
}
