using System;
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
