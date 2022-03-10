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
        private Schedule schedule;
        private AccountDatabase accountDb;
        private string[] workerNames;
        private int day;
        private int time;
        public EditShift(Schedule schedule, AccountDatabase accountDb)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.accountDb = accountDb;
            this.Location = new Point(500, 500);
        }

        private void EditShift_Load(object sender, EventArgs e)
        {

        }

        public void loadWorkers(string workers, int day, int time)
        {
            workerNames = workers.Split('\n');
            this.day = day;
            this.time = time;
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
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
            {
                listBox1.Items.Remove(s);
                string[] workers = workerNames.Where(x => x != s).ToArray();
                schedule.editDays(day, time, workers);
                //accountDb.decrementCurrentWorkedHours(s);
            }     
        }
    }
}
