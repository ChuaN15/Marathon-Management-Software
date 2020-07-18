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
    public partial class RunnerForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public RunnerForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;
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

        private void button1_Click(object sender, EventArgs e)
        {
            new RegisterEventForm(runnerid).Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EditProfileForm(runnerid).Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MyRaceResultForm(runnerid).Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MySponsorshipForm(runnerid).Show();
            Hide();
        }
    }
}
