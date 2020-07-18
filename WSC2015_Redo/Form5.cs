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
    public partial class Form5 : Form
    {
        Timer timer;
        DateTime dt = new DateTime(2019, 8, 22, 6, 0, 0);
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();

        public Form5()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(253, 193, 0);

            TimeSpan ts = dt.Subtract(DateTime.Now);
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = dt.Subtract(DateTime.Now);
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form6().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form1().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new BMIForm().Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new BMPForm().Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new HowLongForm().Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ReviousResultForm().Show();
            Hide();
        }
    }
}
