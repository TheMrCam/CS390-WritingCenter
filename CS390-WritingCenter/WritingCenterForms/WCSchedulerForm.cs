using System;
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
        //scheduleView scheduleView1 = new scheduleView();
        AdminLand adminLand1 = new AdminLand();
        AcctManagePage acctManagePage1 = new AcctManagePage();
        AccountDatabase Accounts = new AccountDatabase();
        UserLand UserLand = new UserLand();
        readonly String defaultPass = "coe"; // change based on user somehow, not sure how to do that - AT

        public WCSchedulerForm()
        {
            InitializeComponent();
            //this.Controls.Add(scheduleView1);
            Accounts.TestCSV(); //for testing
        }

        private void loginError()
        {
            
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if (Accounts.AuthenticateUser(username.Text, password.Text))
            {
                if (Accounts.GetAccount(username.Text).Admin)
                {
                    this.Controls.Add(adminLand1);
                    adminLand1.Show();
                    adminLand1.BringToFront();
                }
                else if (Accounts.GetAccount(username.Text).Equals(defaultPass))  
                {
                    this.Controls.Add(acctManagePage1);
                    //scheduleView1.Show();
                    //scheduleView1.BringToFront();
                }

            }
            else
            {
                loginError();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminLand1.Hide();
            acctManagePage1.Hide();
            //scheduleView1.Hide();
            //this.Location = new Point(0,0);
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            
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
    }
}
