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
    public partial class Form11 : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public Form11()
        {
            InitializeComponent();

            dataGridView1.RowTemplate.Height = 200;

            var alldata = ent.Charities.ToList();
            var allsponsor2 = ent.Sponsorships.ToList();

            decimal total = 0;
            foreach (var item in alldata)
            {
                var allsponsor = ent.Sponsorships.ToList().Where(x => x.Registration.CharityId == item.CharityId).ToList();

                dataGridView1.Rows.Add(Image.FromFile(item.CharityLogo), item.CharityName, allsponsor.Sum(x => x.Amount).ToString("0.00"));
                total += allsponsor.Sum(x => decimal.Parse(x.Amount.ToString()));

            }

            MessageBox.Show(total.ToString());
            label3.Text = "Charities: " + alldata.Count() + "   Total Sponsorships: $" + allsponsor2.Sum(x => x.Amount).ToString("0.00");
            
        }
    }
}
