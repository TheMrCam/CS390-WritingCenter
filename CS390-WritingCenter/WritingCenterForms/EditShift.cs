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
    public partial class EditShift : Form
    {
        public EditShift()
        {
            InitializeComponent();
        }

        private void EditShift_Load(object sender, EventArgs e)
        {

        }

        public void loadWorkers(string workers)
        {
            string[] workerNames = workers.Split('\n');
            foreach(string workerName in workerNames)
            {
                listBox1.Items.Add(workerName);
            }
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {

        }

        private void removeWorkerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
