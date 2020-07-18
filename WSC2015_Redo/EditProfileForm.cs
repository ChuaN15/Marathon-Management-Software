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
    public partial class EditProfileForm : Form
    {
        int runnerid;
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public EditProfileForm(int runnerid)
        {
            InitializeComponent();
            this.runnerid = runnerid;

            textBox1.ReadOnly = true;

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RunnerForm(runnerid).Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var whichrunner = ent.Runners.FirstOrDefault(x => x.RunnerId == runnerid);
            var whichuser = ent.Users.FirstOrDefault(x => x.Email == textBox1.Text);

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill in all of the fields!");
                return;
            }

            if(!string.IsNullOrEmpty(textBox2.Text) || !string.IsNullOrEmpty(textBox3.Text))
            {
                if (textBox2.Text.Length < 6)
                {
                    MessageBox.Show("Password must contains at least 6characters!");
                    return;
                }
                else if (!textBox2.Text.Any(x => Char.IsUpper(x)))
                {
                    MessageBox.Show("Password must contains at least 1uppercase letter!");
                    return;
                }
                else if (!textBox2.Text.Any(x => Char.IsDigit(x)))
                {
                    MessageBox.Show("Password must contains at least 1digit!");
                    return;
                }
                else if (!textBox2.Text.Any(x => "!@#$%^".Contains(x)))
                {
                    MessageBox.Show("Password must contains at least 1 of the following symbols: !@#$%^!");
                    return;
                }
                else if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Password and confirm password must be same!");
                    return;
                }
            }
            
            if ((DateTime.Now.Year - dateTimePicker1.Value.Year) < 10)
            {
                MessageBox.Show("Runner must be at least 10years old!");
                return;
            }
            else
            {

                whichuser.FirstName = textBox4.Text;
                whichuser.LastName = textBox5.Text;

                if(!string.IsNullOrEmpty(textBox2.Text))
                {
                    whichuser.Password = textBox2.Text;
                }
                ent.SaveChanges();
                
                whichrunner.CountryCode = comboBox2.SelectedValue.ToString();
                whichrunner.DateOfBirth = dateTimePicker1.Value;
                whichrunner.Email = textBox1.Text;
                whichrunner.Gender = comboBox1.Text.ToString();
                ent.SaveChanges();

                MessageBox.Show("Profile has been updated");
                new RunnerForm(runnerid).Show();
                Hide();
            }
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.wSC2015_RedoDataSet.Country);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.wSC2015_RedoDataSet.Gender);

            var whichrunner = ent.Runners.FirstOrDefault(x => x.RunnerId == runnerid);

            textBox1.Text = whichrunner.Email;
            dateTimePicker1.Value = whichrunner.DateOfBirth.Value;
            comboBox1.SelectedValue = whichrunner.Gender;
            comboBox2.SelectedValue = whichrunner.CountryCode;
            textBox4.Text = whichrunner.User.FirstName;
            textBox5.Text = whichrunner.User.LastName;
        }
    }
}
