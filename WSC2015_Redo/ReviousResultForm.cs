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
    public partial class ReviousResultForm : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public ReviousResultForm()
        {
            InitializeComponent();
        }

        private void ReviousResultForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.EventType' table. You can move, or remove it, as needed.
            this.eventTypeTableAdapter.Fill(this.wSC2015_RedoDataSet.EventType);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Marathon' table. You can move, or remove it, as needed.
            this.marathonTableAdapter.Fill(this.wSC2015_RedoDataSet.Marathon);

            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            loadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public string category(int age)
        {
            if (age < 18)
            {
                return "Under 18";
            }
            else if (age >= 18 && age <= 29)
            {
                return "18 to 29";
            }
            else if (age >= 30 && age <= 39)
            {
                return "30 to 39";
            }
            else if (age >= 40 && age <= 55)
            {
                return "40 to 55";
            }
            else if (age >= 56 && age <= 70)
            {
                return "56 to 70";
            }
            else
            {
                return "Over 70";
            }
        }

        public void loadData()
        {
            label7.Text = "";
            dataGridView1.Rows.Clear();

            DateTime now = DateTime.Now;
            var alldata = ent.Rank_View.ToList();

            for (int i = 0; i < alldata.Count; i++)
            {
                int age2 = now.Year - alldata[i].DateOfBirth.Value.Year;
                alldata[i].category = category(age2);
            }

            

            var alldata2 = alldata.ToList();
                alldata2 = alldata2.Where(x => x.MarathonName == comboBox1.Text).ToList();
                alldata2 = alldata2.Where(x => x.EventTypeName == comboBox2.Text).ToList();

            if (comboBox3.SelectedIndex != 0)
            {
                alldata2 = alldata2.Where(x => x.Gender == comboBox3.Text).ToList();
            }

            if (comboBox4.SelectedIndex != 0)
            {
                alldata2 = alldata2.Where(x => x.category == comboBox4.Text).ToList();
            }

            int before = alldata2.Count;

                alldata2 = alldata2.Where(x => x.RaceTime > 0).ToList();
            alldata2 = alldata2.OrderBy(x => x.RaceTime).ToList();

            int total = alldata2.Sum(X => int.Parse(X.RaceTime.ToString()));

            try
            {
                TimeSpan ts2 = TimeSpan.FromSeconds((total / alldata2.Count));
                label7.Text = "Total runners: " + before.ToString() + "   " + "Total runners finished: " + alldata2.Count.ToString() + "   Averge race time: " + ts2.Hours.ToString() + "h " + ts2.Minutes.ToString() + "m " + ts2.Seconds.ToString() + "s";
            }
            catch (Exception)
            {
                label7.Text = "Total runners: " + before.ToString() + "   " + "Total runners finished: " + alldata2.Count.ToString() + "   Averge race time: 0h 0m 0s";
            }
            

            

            

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

            for (int i = 0; i < alldata2.Count; i++)
            {
                var whichuser = ent.Runners.ToList().FirstOrDefault(x => x.RunnerId == alldata2[i].RunnerId);
                TimeSpan ts = TimeSpan.FromSeconds(int.Parse(alldata2[i].RaceTime.ToString()));
                dataGridView1.Rows.Add(alldata2[i].overallrank.ToString(), ts.Hours.ToString() + "h " + ts.Minutes.ToString() + "m " + ts.Seconds.ToString() + "s", whichuser.User.FirstName + " " + whichuser.User.LastName, whichuser.CountryCode);
            }
        }
    }
}
