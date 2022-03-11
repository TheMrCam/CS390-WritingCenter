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
    public partial class EditShift : Form, Observable
    {
        private Schedule schedule;
        private AccountDatabase accountDb;
        private List<Observer> sViews;
        private string[] workerNames;
        private int day;
        private int time;
        public EditShift(Schedule schedule, AccountDatabase accountDb)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.accountDb = accountDb;
            sViews = new List<Observer>();
            this.Location = new Point(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void EditShift_Load(object sender, EventArgs e)
        {

        }

        public void loadWorkers(string workers, int day, int time)
        {
            workers = workers.TrimEnd('\n');
            workerNames = workers.Split('\n');
            this.day = day;
            this.time = time;
            foreach (string workerName in workerNames)
            {
                listBox1.Items.Add(workerName);
            }
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            string name = "";
            if (InputBox(ref name) == DialogResult.OK)
            {
                listBox1.Items.Add(name);
            }
            string[] workers = listBox1.Items.OfType<string>().ToArray();
            schedule.editDays(day, time, workers);
            //accountDb.incrementCurrentWorkedHours(name);

        }

        private void removeWorkerButton_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
            {
                listBox1.Items.Remove(s);
                string[] workers = workerNames.Where(x => x != s).ToArray();
                schedule.editDays(day, time, workers);
                workerNames = workers;
                //accountDb.decrementCurrentWorkedHours(s);
            }


        }

        //code taken from https://www.csharp-examples.net/inputbox/
        public static DialogResult InputBox(ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Add Worker";
            label.Text = "Name:";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(buttonOk);
            form.Controls.Add(buttonCancel);
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public void add(Observer obs)
        {
            if (!sViews.Contains(obs))
            {
                sViews.Add(obs);
            }
        }

        public void remove(Observer obs)
        {
           sViews.Remove(obs);
        }

        public void notifyObservers()
        {
            foreach(var view in sViews)
            {
                view.update(time, day);
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            notifyObservers();
            this.Close();
        }
    }
}
