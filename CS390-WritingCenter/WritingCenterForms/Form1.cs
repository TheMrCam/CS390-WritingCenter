﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            schedulePage1.Show();
            schedulePage1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            schedulePage1.Hide();
            adminLand1.Hide();
            acctManagePage1.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedulePage1_Load(object sender, EventArgs e)
        {

        }

        private void adminLogIn_Click(object sender, EventArgs e)
        {
            adminLand1.Show();
            adminLand1.BringToFront();
        }

        private void acctManagePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
