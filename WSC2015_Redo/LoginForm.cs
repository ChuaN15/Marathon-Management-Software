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
    public partial class LoginForm : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public LoginForm()
        {
            InitializeComponent();

            label2.Text = "Login Form \n Please log in to the system using your email address and password.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var whichuser = ent.Users.FirstOrDefault(x => x.Email == textBox1.Text && x.Password == textBox2.Text);
            var whichrunner = ent.Runners.FirstOrDefault(x => x.Email == textBox1.Text);

            if(whichuser == null)
            {
                MessageBox.Show("Please enter valid email and password to login.");
                return;
            }
            else if(whichuser.RoleId == "R")
            {
                new RunnerForm(whichrunner.RunnerId).Show();
                Hide();
            }
            else if (whichuser.RoleId == "A")
            {
                new AdminForm().Show();
                Hide();
            }
            else if (whichuser.RoleId == "C")
            {
                new CoordinatorForm().Show();
                Hide();
            }
        }
    }
}
