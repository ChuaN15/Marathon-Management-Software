﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2015_Redo
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VolunteerManagementFormcs().Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}