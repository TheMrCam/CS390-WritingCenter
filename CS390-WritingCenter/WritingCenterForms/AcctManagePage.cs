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
        public AcctManagePage()
        {
            InitializeComponent();
        }

        private void uploadCSV_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
