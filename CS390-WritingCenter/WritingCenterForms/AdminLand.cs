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
    public partial class AdminLand : UserControl
    {
        scheduleView scheduleView1; //= new scheduleView();
        AcctManagePage AcctManagePage1 = new AcctManagePage();
        Settings settingPage = new Settings();
        public AdminLand(scheduleView scheduleView1)
        {
            InitializeComponent();
            this.scheduleView1 = scheduleView1;
            this.Controls.Add(scheduleView1);
            this.Controls.Add(AcctManagePage1);
            this.Controls.Add(settingPage);

            scheduleView1.Hide();
            AcctManagePage1.Hide();
            settingPage.Hide();
        }

        private void manageAcct_Click(object sender, EventArgs e)
        {
            AcctManagePage1.Show();
            AcctManagePage1.BringToFront();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settingPage.Show();
            settingPage.BringToFront();
        }

        private void EditReq_Click(object sender, EventArgs e)
        {

        }

        private void ManageSched_Click(object sender, EventArgs e)
        {
            scheduleView1.Show();
            scheduleView1.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void coeLogo_Click(object sender, EventArgs e)
        {

        }

        private void AdminLand_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
