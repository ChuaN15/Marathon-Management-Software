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
    public partial class Form6 : Form
    {
        Timer timer;
        DateTime dt = new DateTime(2019, 8, 22, 6, 0, 0);
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();

        public Form6()
        {
            InitializeComponent();

            dataGridView1.RowTemplate.Height = 200;

            this.BackColor = Color.FromArgb(253, 193, 0);

            TimeSpan ts = dt.Subtract(DateTime.Now);
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            var allcha = ent.Charities.ToList();

            foreach (var item in allcha)
            {
                dataGridView1.Rows.Add(Image.FromFile(item.CharityLogo), item.CharityName + "\n" + item.CharityDescription);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = dt.Subtract(DateTime.Now);
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form5().Show();
            Hide();
        }
    }
}
