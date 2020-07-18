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
    public partial class Form3 : Form
    {
        int total = 0;
        Timer timer;
        DateTime dt = new DateTime(2019, 8, 22, 6, 0, 0);
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public Form3(int sponsorid)
        {
            InitializeComponent();

            var whichsponsor = ent.Sponsorships.FirstOrDefault(x => x.SponsorshipId == sponsorid);

            this.BackColor = Color.FromArgb(253, 193, 0);
            TimeSpan ts = dt.Subtract(DateTime.Now);

            loadTime();

            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";

            label2.Text = "Thank you for your sponsorship \n\n" +
                "Thank you for sponsoring a runner in Marathon Skills 2015 \n Your donation will help out their chosen charity.\n\n" +
                whichsponsor.Registration.Runner.User.FirstName + " " + whichsponsor.Registration.Runner.User.LastName + " (" + whichsponsor.Registration.Runner.CountryCode + ")" + " from " + whichsponsor.Registration.Runner.Country.CountryName + "\n\n"
                + whichsponsor.Registration.Charity.CharityName + "\n\n" + "$" + whichsponsor.Amount;
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
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form1().Show();
            Hide();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            timer.Stop();
            new Form1().Show();
            Hide();
        }
    }
}
