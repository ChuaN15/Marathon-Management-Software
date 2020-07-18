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
    public partial class Form8 : Form
    {
        int runnerid;
        public Form8(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            label2.Text = "Thank you for registering as a runner! \n\n" +
                "Thank you for registering as a runner in Marathon Skills 2015! \n\n" +
                "You will be contacted soon about payment.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
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
