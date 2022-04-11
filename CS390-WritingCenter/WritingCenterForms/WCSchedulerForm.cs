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
    public partial class WCSchedulerForm : Form
    {        
        public static AccountDatabase Accounts = new AccountDatabase();
        private static scheduleView scheduleView1 = new scheduleView(Accounts);
        AdminPage adminPage = new AdminPage(scheduleView1);
        AcctManagePage acctManagePage1 = new AcctManagePage();
        public static Account currentAccount = null;
        readonly String defaultPass = "coe"; // change based on user somehow, not sure how to do that - AT
        ErrorProvider errorProvider = new ErrorProvider();

        public WCSchedulerForm()
        {
            InitializeComponent();
            //Accounts.TestCSV(); //for testing
            Accounts.TestResponsesCSV();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            //If username or password is empty, it shows error
            if (string.IsNullOrWhiteSpace(username.Text) || username.Text.Equals("Username"))
            {
                errorProvider.Clear();
                errorProvider.SetError(username, "Username required!");
            }
            else if (string.IsNullOrWhiteSpace(password.Text) || password.Text.Equals("Password"))
            {
                errorProvider.Clear();
                errorProvider.SetError(password, "Password required!");
            }
            else
            {
                authenticateUser();
            }

        }

        private void authenticateUser()
        {
            if (Accounts.AuthenticateUser(username.Text, password.Text))
            {
                currentAccount = Accounts.GetAccount(username.Text);
                if (currentAccount.Admin)
                {
                    this.Controls.Add(adminPage);
                    adminPage.Show();
                    adminPage.BringToFront();
                }
                else if (!currentAccount.Admin)
                {
                    adminPage.isNotAdmin();
                    this.Controls.Add(adminPage);
                    adminPage.Show();
                    adminPage.BringToFront();
                }
                else if (Accounts.GetAccount(username.Text).Equals(defaultPass))
                {
                    this.Controls.Add(acctManagePage1);
                }

            }
            else
            {
                loginError();
            }
        }

        private void loginError()
        {
            MessageBox.Show("Incorrect Username or Password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            acctManagePage1.Hide();
            scheduleView1.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetLogin(object sender, EventArgs e)
        {
            username.Text = "Username";
            password.UseSystemPasswordChar = false;
            password.Text = "Password";
        }

        private void leftUsernameBox(object sender, EventArgs e)
        {
            if (username.Text.Equals(""))
            {
                username.Text = "Username";
            }
                    
        }

        private void leftPasswordBox(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.UseSystemPasswordChar = false; 
            }
                
        }

        private void enterPasswordBox(object sender, EventArgs e)
        {
            if (password.Text.Equals("Password"))
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
            }
            
        }

        private void enterUsernameBox(object sender, EventArgs e)
        {
            if (username.Text.Equals("Username"))
            {
                username.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private async void DatabaseDebug_Click(object sender, EventArgs e)
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
                        await Task.Run(() => File.WriteAllLines(fileName, Accounts.DatabaseLines(clean)));
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

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void passwordKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                logIn_Click(sender, e);
            }
        }

        private void WCSchedulerForm_SizeChanged(object sender, EventArgs e)
        {
            //scheduleView1.sizeChanged(this.WindowState);
        }
    }
}
