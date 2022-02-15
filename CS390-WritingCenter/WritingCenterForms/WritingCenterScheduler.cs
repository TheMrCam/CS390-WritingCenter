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
    public partial class WritingCenterScheduler : Form
    {
        public WritingCenterScheduler()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            ///
            /// User verification goes here
            /// for now change which page you want here
            ///
            ///userLand1.Show();
            
            adminLand1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminLand1_Load(object sender, EventArgs e)
        {

        }

        private void ManageSched_Click(object sender, EventArgs e)
        {
            adminLand1.Hide();
        }
    }
}
