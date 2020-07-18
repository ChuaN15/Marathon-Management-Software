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
    public partial class RegisterEventForm : Form
    {
        int total = 0;
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public RegisterEventForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            label2.Text = "Register for an event\n\n" +
                "Please fill out all of the following information to register for events in the Skills Marathon 2015 being held in Sao Pau.o, Brazil. You will be contacted after you have registered to organise payment and other details.";


            radioButton1.Checked = true;
            loadPrice();

        }

        public void loadPrice()
        {
            total = 0;
            if(checkBox1.Checked)
            {
                total += 145;
            }

            if(checkBox2.Checked)
            {
                total += 75;
            }

            if (checkBox3.Checked)
            {
                total += 20;
            }

            if(radioButton1.Checked)
            {
                total += 0;
            }
            else if(radioButton2.Checked)
            {
                total += 20;
            }
            else
            {
                total += 45;
            }

            label8.Text = "$" + total;
        }

        private void RegisterEventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Charity' table. You can move, or remove it, as needed.
            this.charityTableAdapter.Fill(this.wSC2015_RedoDataSet.Charity);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int raise = 0;
            if (!int.TryParse(textBox5.Text, out raise))
            {
                MessageBox.Show("Please enter valid target to raise!");
                return;
            }
            else if (raise <= 0)
            {
                MessageBox.Show("Please enter valid positive amount to raise!");
                return;
            }
            else
            {
                if(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                {
                    MessageBox.Show("Please select at least an event!");
                    return;
                }

                Registration reg = new Registration();
                reg.CharityId = int.Parse(comboBox1.SelectedValue.ToString());
                reg.Cost = total;
                reg.RegistrationDateTime = DateTime.Now;
                reg.RegistrationStatusId = 1;
                reg.RunnerId = runnerid;
                reg.SponsorshipTarget = raise;

                if(radioButton1.Checked)
                {
                    reg.RaceKitOptionId = "A";
                }
                else if (radioButton1.Checked)
                {
                    reg.RaceKitOptionId = "B";
                }
                else
                {
                    reg.RaceKitOptionId = "C";
                }
                ent.Registrations.Add(reg);
                ent.SaveChanges();

                if(checkBox1.Checked)
                {
                    RegistrationEvent rege = new RegistrationEvent();
                    rege.RegistrationId = reg.RegistrationId;
                    rege.EventId = "15_5FM";
                    ent.RegistrationEvents.Add(rege);
                    ent.SaveChanges();
                }

                if (checkBox2.Checked)
                {
                    RegistrationEvent rege = new RegistrationEvent();
                    rege.RegistrationId = reg.RegistrationId;
                    rege.EventId = "15_5HM";
                    ent.RegistrationEvents.Add(rege);
                    ent.SaveChanges();
                }

                if (checkBox3.Checked)
                {
                    RegistrationEvent rege = new RegistrationEvent();
                    rege.RegistrationId = reg.RegistrationId;
                    rege.EventId = "15_5FR";
                    ent.RegistrationEvents.Add(rege);
                    ent.SaveChanges();
                }

                new Form8(runnerid).Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4(int.Parse(comboBox1.SelectedValue.ToString())).ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            loadPrice();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}
