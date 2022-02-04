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
    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            panelList[0].Show();
            panelList[0].BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            panelList[0].Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelList.Add(schedulePage);
            panelList[0].Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
