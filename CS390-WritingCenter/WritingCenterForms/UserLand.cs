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
    public partial class UserLand : UserControl
    {
        scheduleView scheduleView1 = new scheduleView();
        public UserLand()
        {
            InitializeComponent();
            this.Controls.Add(scheduleView1);

            scheduleView1.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitEditReqButton_Click(object sender, EventArgs e)
        {

        }

        private void manageSched_Click(object sender, EventArgs e)
        {
            scheduleView1.Show();
            scheduleView1.BringToFront();
        }

        private void UserLand_Load(object sender, EventArgs e)
        {

        }
    }
}
