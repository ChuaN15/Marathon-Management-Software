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
    public partial class Form4 : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public Form4(int chaid)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 193, 0);

            var whichcha = ent.Charities.FirstOrDefault(x => x.CharityId == chaid);

            pictureBox1.Image = Image.FromFile(whichcha.CharityLogo);
            label1.Text = whichcha.CharityName;
            label2.Text = whichcha.CharityDescription;
        }
    }
}
