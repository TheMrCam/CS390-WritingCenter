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
    public partial class SettingsPage : UserControl
    {
        Day[] days = new Day[7];
        public SettingsPage()
        {
            InitializeComponent();

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void shiftControls1_Load(object sender, EventArgs e)
        {

        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void TuedayTab_Click(object sender, EventArgs e)
        {

        }

        private void SaturdayTab_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
