using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2015_Redo
{
    public partial class UserControl1 : UserControl
    {
        string name,image;
        HowLongForm form;
        public UserControl1(HowLongForm form,string name, string image)
        {
            InitializeComponent();
            this.form = form;
            this.name = name;

            pictureBox1.Image = Image.FromFile(image);
            label1.Text = name;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            form.loadSelected(name);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form.loadSelected(name);

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            form.loadSelected(name);
        }
    }
}
