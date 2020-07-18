using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2015_Redo
{
    public partial class Form1 : Form
    {
        Timer timer;
        DateTime dt = new DateTime(2019, 8, 22, 6, 0, 0);
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(253, 193, 0);

            TimeSpan ts = dt.Subtract(DateTime.Now);
            label1.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";

            loadTime();

            var buttonlist = this.Controls.OfType<Button>().ToList();
            foreach (var item in buttonlist)
            {
                item.BackColor = Color.Blue;
                item.ForeColor = Color.White;
            }
        }

        void loadTime()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = dt.Subtract(DateTime.Now);
            label1.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var allstaff = ent.Staffs.ToList();

            //foreach (var item in allstaff)
            //{
            //    string[] strings = item.FirstName.Split('|', '*', '#');

            //    item.FirstName = strings[0];
            //    item.LastName = strings[1];
            //    ent.SaveChanges();

            //    try
            //    {
            //        new MailAddress(item.Email);
            //    }
            //    catch (Exception)
            //    {
            //        ent.Staffs.Remove(item);
            //        ent.SaveChanges();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form2().Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form5().Show();
            Hide();
        }

        Bitmap bm;

        private void button4_Click(object sender, EventArgs e)
        {
            //bm = new Bitmap(this.Width, this.Height);
            //this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
            //printDocument1.PrintPage += PrintDocument1_PrintPage;

            //printDocument1.Print();

            timer.Stop();
            new LoginForm().Show();
            Hide();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage((Image)bm, new Point(0,0));

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            new RegisterRunnerForm().Show();
            Hide();
        }
    }
}
