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
    public partial class CertificateForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public CertificateForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

           
        }

        private void CertificateForm_Load(object sender, EventArgs e)
        {
            var whichrege6 = ent.RegistrationEvents.Where(x => x.RaceTime > 0 && x.Registration.RunnerId == runnerid && x.Event.MarathonId == 4).ToList();

            if (whichrege6.Count == 0)
            {
                Hide();
                MessageBox.Show("No result");
            }
            else
            {
                for (int i = 0; i < whichrege6.Count; i++)
                {
                    comboBox1.Items.Add(whichrege6[i].Event.EventType.EventTypeName);
                }
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var whichrunner = ent.Runners.FirstOrDefault(X => X.RunnerId == runnerid);
            var whichrege6 = ent.RegistrationEvents.Where(x => x.RaceTime > 0 && x.Registration.RunnerId == runnerid && x.Event.MarathonId == 4).ToList();


            var alldata = ent.Rank_View.ToList();

            alldata = alldata.Where(x => x.RaceTime > 0).ToList();
            alldata = alldata.OrderBy(x => x.RaceTime).ToList();

            var whichdata = alldata.Where(x => x.RunnerId == runnerid).ToList();

            for (int i = 0; i < whichdata.Count; i++)
            {
                var alldata2 = alldata.Where(x => x.MarathonName == "Marathon Skills 2014" && x.EventTypeName == comboBox1.Text).ToList();

                int overallrank = 0, temprank = 1;
                for (int j = 0; j < alldata2.Count(); j++)
                {
                    if (j > 0)
                    {
                        if (alldata2[j].RaceTime == alldata2[j - 1].RaceTime)
                        {
                            alldata2[j].overallrank = overallrank;
                            temprank++;
                        }
                        else
                        {

                            overallrank += temprank;
                            alldata2[j].overallrank = overallrank;
                            temprank = 1;
                        }

                    }
                    else
                    {
                        overallrank = j + 1;
                        alldata2[j].overallrank = overallrank;
                    }
                }

                var whichrunnerdata = alldata2.FirstOrDefault(x => x.RunnerId == runnerid);
                var allsponsor = ent.Sponsorships.ToList().Where(x => x.RegistrationId == whichrege6.FirstOrDefault().RegistrationId);

                TimeSpan ts = TimeSpan.FromSeconds((double)whichrunnerdata.RaceTime);

                label1.Text = "Congratulations " + whichrunner.User.FirstName + " " + whichrunner.User.LastName + " for running in the " + comboBox1.Text + ".\nYou ran a time of " + ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + " and got a rank of " + whichrunnerdata.overallrank.ToString();
                label2.Text = "Certificate of Participation \n in \n Marathon Skills 2014\nOsaka, Japan";
                label3.Text = "You also raised $" + allsponsor.Sum(x => x.Amount).ToString("0.00") + " for " + whichrege6.FirstOrDefault().Registration.Charity.CharityName;

                pictureBox2.Image = Image.FromFile("tick-icon.png");

            }
        }
    }
}
