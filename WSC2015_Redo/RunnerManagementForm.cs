using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2015_Redo
{
    public partial class RunnerManagementForm : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public RunnerManagementForm()
        {
            InitializeComponent();

            //var allreg = ent.RegistrationEvents.ToList();

            //var allreg2 = allreg.GroupBy(x => new { x.Registration.RunnerId }).Select(x => new { x.Key.RunnerId, ticcount = x.Count() });

            //allreg2 = allreg2.OrderByDescending(x => x.ticcount);

            //foreach (var item in allreg2)
            //{
            //    dataGridView2.Rows.Add(item.RunnerId, item.ticcount);
            //}
        }

        private void RunnerManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.EventType' table. You can move, or remove it, as needed.
            this.eventTypeTableAdapter.Fill(this.wSC2015_RedoDataSet.EventType);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.RegistrationStatus' table. You can move, or remove it, as needed.
            this.registrationStatusTableAdapter.Fill(this.wSC2015_RedoDataSet.RegistrationStatus);

            comboBox3.SelectedIndex = 0;
            loadData();
        }

        public void loadData()
        {
            dataGridView1.Rows.Clear();
            var alldata = ent.Runner_View.ToList();

            alldata = alldata.Where(x => x.RegistrationStatus == comboBox1.Text && x.EventTypeName == comboBox2.Text && x.MarathonId == 5).ToList();

            if(comboBox3.SelectedIndex == 0)
            {
                alldata = alldata.OrderBy(x => x.FirstName).ToList();
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                alldata = alldata.OrderBy(x => x.LastName).ToList();
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                alldata = alldata.OrderBy(x => x.Email).ToList();
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                alldata = alldata.OrderBy(x => x.RegistrationStatus).ToList();
            }

            label6.Text = "Total runners: " + alldata.Count.ToString();

            foreach (var item in alldata)
            {
                var whichrege6 = ent.RegistrationEvents.ToList().Where(x => x.Registration.RunnerId == item.RunnerId).ToList();

                dataGridView1.Rows.Add(item.FirstName, item.LastName, item.Email, item.RegistrationStatus,whichrege6.Count);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                text += dataGridView1.Rows[i].Cells[0].Value.ToString() + " " + dataGridView1.Rows[i].Cells[1].Value.ToString() + "<" + dataGridView1.Rows[i].Cells[2].Value.ToString() + ">;" + Environment.NewLine;
            }

            new Form10(text).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV | *.csv";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(sfd.FileName).ToLower() != ".csv")
                {
                    MessageBox.Show("Only csv");
                    return;
                }
                else
                {
                    string text = "";
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        var whichuser = ent.Runners.ToList().FirstOrDefault(x => x.Email == dataGridView1.Rows[i].Cells[2].Value.ToString());

                        var whichregevent = ent.RegistrationEvents.ToList().FirstOrDefault(X => X.Registration.RunnerId == whichuser.RunnerId && X.Event.MarathonId == 5);
                        text += dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[1].Value.ToString() + "," + dataGridView1.Rows[i].Cells[2].Value.ToString()
                            + "," + whichuser.Gender +
                            "," + whichuser.Country.CountryName +
                            "," + whichuser.DateOfBirth +
                            "," + whichregevent.Registration.RegistrationStatu.RegistrationStatus;

                        var whichregevent2 = ent.RegistrationEvents.ToList().Where(x => x.Registration.RunnerId == whichuser.RunnerId).ToList();

                        for (int j = 0; j < whichregevent2.Count; j++)
                        {
                            text += "," + whichregevent2[j].Event.EventType.EventTypeName;
                        }

                        text += Environment.NewLine;
                    }

                    File.WriteAllText(sfd.FileName, text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].ColumnIndex == 4)
                {
                    var whichrunner = ent.Runners.ToList().FirstOrDefault(X => X.Email == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                    new ManageARunnerForm(whichrunner.RunnerId).ShowDialog();
                }
            }
            
        }
    }
}
