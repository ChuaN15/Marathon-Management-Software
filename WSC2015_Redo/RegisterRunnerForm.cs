using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2015_Redo
{
    public partial class RegisterRunnerForm : Form
    {
        WSC2015_RedoEntities ent = new WSC2015_RedoEntities();
        public RegisterRunnerForm()
        {
            InitializeComponent();

            label2.Text = "Register as a runner\n\nPlease fill out all of the following information to be registered as a runner.";

            var buttonlist = this.Controls.OfType<Button>().ToList();
            foreach (var item in buttonlist)
            {
                item.BackColor = Color.Blue;
                item.ForeColor = Color.White;
            }

        }

        private void RegisterRunnerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.wSC2015_RedoDataSet.Country);
            // TODO: This line of code loads data into the 'wSC2015_RedoDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.wSC2015_RedoDataSet.Gender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill in all of the fields!");
                return;
            }

            try
            {
                new MailAddress(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid email address!");
                return;
            }

            if(textBox2.Text.Length < 6)
            {
                MessageBox.Show("Password must contains at least 6characters!");
                return;
            }
            else if(!textBox2.Text.Any(x => Char.IsUpper(x)))
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
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password and confirm password must be same!");
                return;
            }
            else if ((DateTime.Now.Year - dateTimePicker1.Value.Year) < 10)
            {
                MessageBox.Show("Runner must be at least 10years old!");
                return;
            }
            else
            {
                User user = new User();
                user.Email = textBox1.Text;
                user.FirstName = textBox4.Text;
                user.LastName = textBox5.Text;
                user.Password = textBox2.Text;
                user.RoleId = "R";
                ent.Users.Add(user);
                ent.SaveChanges();

                Runner runner = new Runner();
                runner.CountryCode = comboBox2.SelectedValue.ToString();
                runner.DateOfBirth = dateTimePicker1.Value;
                runner.Email = textBox1.Text;
                runner.Gender = comboBox1.Text.ToString();
                ent.Runners.Add(runner);
                ent.SaveChanges();

                

                new RegisterEventForm(runner.RunnerId).Show();
                Hide();
            }
        }
    }
}
