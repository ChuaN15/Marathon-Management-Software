using System;
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
    public partial class CoordinatorForm : Form
    {
        public CoordinatorForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void CoordinatorForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RunnerManagementForm().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            Hide();
        }
    }
}
