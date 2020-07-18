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
    public partial class VolunteerManagementFormcs : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public VolunteerManagementFormcs()
        {
            InitializeComponent();
        }

        private void VolunteerManagementFormcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Volunteer_View' table. You can move, or remove it, as needed.
            this.volunteer_ViewTableAdapter.Fill(this.wSC2015_RedoDataSet.Volunteer_View);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Volunteer' table. You can move, or remove it, as needed.
            this.volunteerTableAdapter.Fill(this.wSC2015_RedoDataSet.Volunteer);

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            var alldata = ent.Volunteer_View.ToList();

            if (comboBox1.SelectedIndex == 0)
            {
                alldata = alldata.OrderBy(x => x.FirstName).ToList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                alldata = alldata.OrderBy(x => x.LastName).ToList();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                alldata = alldata.OrderBy(x => x.CountryCode).ToList();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                alldata = alldata.OrderBy(x => x.Gender).ToList();
            }
            
            for (int i = 0; i < alldata.Count; i++)
            {
                dataGridView1.DataSource = alldata;
            }

            label3.Text = alldata.Count().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EXCEL | *.csv";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var allcsv = File.ReadAllLines(openFileDialog.FileName);
                var csvwithcols = allcsv.Select(x => x.Split(','));

                foreach (var item in csvwithcols)
                {
                    try
                    {
                        //1	LUCIA	BURCH	BRA	F
                        Volunteer vol = new Volunteer();
                        vol.VolunteerId = int.Parse(item[0].ToString());
                        vol.FirstName = item[1].ToString();
                        vol.LastName = item[2].ToString();
                        vol.CountryCode = item[3].ToString();
                        if(item[4].ToString() == "F")
                        {
                            vol.Gender = "Female";
                        }
                        else
                        {
                            vol.Gender = "Male";
                        }
                        
                        ent.Volunteers.Add(vol);
                        ent.SaveChanges();

                        loadData();
                    }
                    catch (Exception e2)
                    {
                    }
                    
                }
            }
        }
    }
}
