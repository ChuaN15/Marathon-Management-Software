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
    public partial class ManageARunnerForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public ManageARunnerForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            loadData();
        }

        public void loadData()
        {
            ent = new WSC2015_RedoEntities();
            var whichrunner = ent.Runners.FirstOrDefault(x => x.RunnerId == runnerid);

            label3.Text = "Email: " + whichrunner.Email + "\n" +
                "First Name: " + whichrunner.User.FirstName + "\n" +
                "Last Name: " + whichrunner.User.LastName + "\n" +
                "Gender: " + whichrunner.User.LastName + "\n" +
                "Date of Birth: " + whichrunner.DateOfBirth.Value.ToString(@"dd MON yyyy") + "\n" +
                "Country: " + whichrunner.Country.CountryName + "\n" +
                "Charity: " + whichrunner.Registrations.LastOrDefault().Charity.CharityName + "\n" +
                "Target to Raise: $" + whichrunner.Registrations.LastOrDefault().SponsorshipTarget.ToString("0.00") + "\n" +
                "Race Kit Option: Option" + whichrunner.Registrations.LastOrDefault().RaceKitOptionId + "\n" +
                "Race Events: ";

            var whichrege = ent.RegistrationEvents.Where(x => x.Registration.RunnerId == runnerid && x.Event.MarathonId == 5).ToList();

            for (int i = 0; i < whichrege.Count; i++)
            {
                label3.Text += whichrege[i].Event.EventType.EventTypeName;

                if (i + 1 != whichrege.Count)
                {
                    label3.Text += ",";
                }
            }

            if(whichrunner.Registrations.LastOrDefault().RegistrationStatusId == 4)
            {
                pictureBox4.Image = Image.FromFile("tick-icon.png");
                pictureBox3.Image = Image.FromFile("tick-icon.png");
                pictureBox2.Image = Image.FromFile("tick-icon.png");
                pictureBox1.Image = Image.FromFile("tick-icon.png");
            }
            else if (whichrunner.Registrations.LastOrDefault().RegistrationStatusId == 3)
            {
                pictureBox4.Image = Image.FromFile("cross-icon.png");
                pictureBox3.Image = Image.FromFile("tick-icon.png");
                pictureBox2.Image = Image.FromFile("tick-icon.png");
                pictureBox1.Image = Image.FromFile("tick-icon.png");
            }
            else if (whichrunner.Registrations.LastOrDefault().RegistrationStatusId == 2)
            {
                pictureBox4.Image = Image.FromFile("cross-icon.png");
                pictureBox3.Image = Image.FromFile("cross-icon.png");
                pictureBox2.Image = Image.FromFile("tick-icon.png");
                pictureBox1.Image = Image.FromFile("tick-icon.png");
            }
            else if (whichrunner.Registrations.LastOrDefault().RegistrationStatusId == 1)
            {
                pictureBox4.Image = Image.FromFile("cross-icon.png");
                pictureBox3.Image = Image.FromFile("cross-icon.png");
                pictureBox2.Image = Image.FromFile("cross-icon.png");
                pictureBox1.Image = Image.FromFile("tick-icon.png");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CertificateForm(runnerid).ShowDialog();
        }
    }
}
