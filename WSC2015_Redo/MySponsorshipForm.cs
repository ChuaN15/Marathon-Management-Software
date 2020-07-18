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
    public partial class MySponsorshipForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public MySponsorshipForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            var whichrunner = ent.Runners.FirstOrDefault(x => x.RunnerId == runnerid);
            var whcihregevent = ent.RegistrationEvents.FirstOrDefault(x => x.Registration.RunnerId == runnerid && x.Event.MarathonId == 5);
            var allsponsor = ent.Sponsorships.Where(x => x.RegistrationId == whcihregevent.RegistrationId).ToList();

            label3.Text = whcihregevent.Registration.Charity.CharityName;
            label4.Text = whcihregevent.Registration.Charity.CharityDescription;
            pictureBox1.Image = Image.FromFile(whcihregevent.Registration.Charity.CharityLogo);

            for (int i = 0; i < allsponsor.Count; i++)
            {
                dataGridView1.Rows.Add(allsponsor[i].SponsorName, "$" + allsponsor[i].Amount.ToString("0.00"));
            }

            dataGridView1.Rows.Add("Total", "$" + allsponsor.Sum(x => x.Amount).ToString("0.00"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
        }
    }
}
