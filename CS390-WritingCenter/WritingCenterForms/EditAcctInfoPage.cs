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
    public partial class EditAcctInfoPage : UserControl
    {
        Schedule schedule1 = null;
        public EditAcctInfoPage()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            //somthing to get out of last page too
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sunHrBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            WCSchedulerForm.Accounts.submitUpdateRequest("null", "null", 0, new string[1], new string[1], 0);

        }

        private void EditAcctInfoPage_Load(object sender, EventArgs e)
        {

        }
    }
}
