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
    public partial class MyRaceResultForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public MyRaceResultForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            var whichrunner = ent.Runners.FirstOrDefault(x => x.RunnerId == runnerid);
            DateTime now = DateTime.Now;
            int age = now.Year - whichrunner.DateOfBirth.Value.Year;

            label3.Text = "Gender: " + whichrunner.Gender + "   Age category: " + category(age);

            var alldata = ent.Rank_View.ToList();

            for (int i = 0; i < alldata.Count; i++)
            {
                int age2 = now.Year - alldata[i].DateOfBirth.Value.Year;
                alldata[i].category = category(age2);
            }

            alldata = alldata.Where(x => x.RaceTime > 0).ToList();
            alldata = alldata.OrderBy(x => x.RaceTime).ToList();

            var whichdata = alldata.Where(x => x.RunnerId == runnerid).ToList();

            for (int i = 0; i < whichdata.Count; i++)
            {
                var alldata2 = alldata.Where(x => x.MarathonName == whichdata[i].MarathonName && x.EventName == whichdata[i].EventName).ToList();
                var alldata3 = alldata.Where(x => x.MarathonName == whichdata[i].MarathonName && x.EventName == whichdata[i].EventName && x.category == category(age) && x.Gender == whichrunner.Gender).ToList();

                int overallrank = 0, temprank=1,categoryrank = 0;
                for (int j = 0; j < alldata2.Count(); j++)
                {
                    if(j > 0)
                    {
                        if(alldata2[j].RaceTime == alldata2[j-1].RaceTime)
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

                temprank = 1;
                for (int j = 0; j < alldata3.Count(); j++)
                {
                    if (j > 0)
                    {
                        if (alldata3[j].RaceTime == alldata3[j - 1].RaceTime)
                        {
                            alldata3[j].categoryrank = categoryrank;
                            temprank++;
                        }
                        else
                        {
                            alldata3[j].categoryrank = categoryrank;
                            temprank = 1;
                            categoryrank += temprank;
                        }

                    }
                    else
                    {
                        categoryrank = j + 1;
                        alldata3[j].categoryrank = categoryrank;
                    }

                }
                TimeSpan ts = TimeSpan.FromSeconds(int.Parse(whichdata[i].RaceTime.ToString()));
                dataGridView1.Rows.Add(whichdata[i].MarathonName, whichdata[i].EventName, ts.Hours.ToString() + "h " + ts.Minutes.ToString() + "m " + ts.Seconds.ToString() + "s", alldata2.FirstOrDefault(x => x.RunnerId == whichrunner.RunnerId).overallrank.ToString(), alldata3.FirstOrDefault(x => x.RunnerId == whichrunner.RunnerId).categoryrank.ToString());
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
        }
    }
}
