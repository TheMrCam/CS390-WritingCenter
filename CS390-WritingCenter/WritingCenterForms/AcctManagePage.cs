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
    public partial class AcctManagePage : UserControl
    {
        EditAcctInfoPage EditAcctInfoPage1 = new EditAcctInfoPage();
        public AcctManagePage()
        {
            InitializeComponent();

            this.Controls.Add(EditAcctInfoPage1);

            EditAcctInfoPage1.Hide();
        }

        private void uploadCSV_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void manualEntry_Click(object sender, EventArgs e)
        {
            EditAcctInfoPage1.Show();
            EditAcctInfoPage1.BringToFront();
        }
    }
}
