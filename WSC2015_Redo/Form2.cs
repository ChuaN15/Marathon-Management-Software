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
    public partial class Form2 : Form
    {
        int total = 0;
        Timer timer;
        DateTime dt = new DateTime(2019, 8, 22, 6, 0, 0);
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 193, 0);

            label2.Text = "Sponsor a runner \n\n Please choose the runner you would like to sponsor and the amount you would like to sponsor them for. Thank you for your support of the runners and their charities!";
            TimeSpan ts = dt.Subtract(DateTime.Now);
            label10.Text = ts.Days + " days " + ts.Hours + " hours and " + ts.Minutes + " minutes until the race starts!";

            loadTime();
            loadAmount();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Sponsor_View' table. You can move, or remove it, as needed.
            this.sponsor_ViewTableAdapter.Fill(this.wSC2015_RedoDataSet.Sponsor_View);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Runner' table. You can move, or remove it, as needed.
            this.runnerTableAdapter.Fill(this.wSC2015_RedoDataSet.Runner);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            total++;
            textBox8.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total--;
            textBox8.Text = total.ToString();
        }

        public void loadAmount()
        {
            label14.Text = "$" + total;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime dt = new DateTime(int.Parse(textBox7.Text), int.Parse(textBox5.Text), 1);

                if(dt <= DateTime.Now)
                {
                    MessageBox.Show("Expiry date must be after today's date!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid exoiry date!");
                return;
            }

            int cc,cvc;
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Please fill in all of the fields!");
                return;
            }
            else if(textBox4.Text.Length != 16 || !textBox4.Text.Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("Credit card must be 16digits!");
                return;
            }
            else if(textBox6.Text.Length != 3 || !textBox6.Text.Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("CVC must be 3digits!");
                return;
            }
            else
            {
                var whichregevent = ent.RegistrationEvents.ToList().FirstOrDefault(X => X.RegistrationEventId == int.Parse(comboBox1.SelectedValue.ToString()));
                Sponsorship sponsorship = new Sponsorship();
                sponsorship.Amount = total;
                sponsorship.RegistrationId = whichregevent.RegistrationId;
                sponsorship.SponsorName = textBox1.Text;
                ent.Sponsorships.Add(sponsorship);
                ent.SaveChanges();

                timer.Stop();
                new Form3(sponsorship.SponsorshipId).Show();
                Hide();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox8.Text,out total))
            {
                textBox8.Text = total.ToString();
            }

            loadAmount();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                int regid = int.Parse(comboBox1.SelectedValue.ToString());
                var whichreg = ent.RegistrationEvents.FirstOrDefault(x => x.RegistrationEventId == regid);
                label12.Text = whichreg.Registration.Charity.CharityName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int regid = int.Parse(comboBox1.SelectedValue.ToString());
            var whichreg = ent.RegistrationEvents.FirstOrDefault(x => x.RegistrationEventId == regid);

            new Form4(whichreg.Registration.CharityId).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new Form1().Show();
            Hide();
        }
    }
}
