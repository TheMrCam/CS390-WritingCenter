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
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        public void updateAlertBox(string[] underWorkers, string[] overWorkers, string[] notWorkers)
        {
            UnderHoursBox.DataSource = underWorkers;
            OverHoursBox.DataSource = overWorkers;
            NoHoursBox.DataSource = notWorkers;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }
    }
}
