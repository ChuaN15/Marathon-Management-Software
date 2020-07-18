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
    public partial class BMPForm : Form
    {
        public BMPForm()
        {
            InitializeComponent();
        }

        private void BMPForm_Load(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Black;
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Black;
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
            pictureBox3.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = 0, height = 0, age = 0;
            double BMR;

            if (!double.TryParse(textBox1.Text, out height) || !double.TryParse(textBox2.Text, out weight) || !double.TryParse(textBox3.Text, out age))
            {
                MessageBox.Show("Please enter valid value of height, weight and age!");
                return;
            }
            else
            {
                if (pictureBox4.BackColor == Color.White)
                {
                    BMR = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
                }
                else
                {
                    BMR = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
                }

                label7.Text = BMR.ToString();

                label9.Text = "Sedentary: " + (BMR * 1.2).ToString();
                label10.Text = "Lightly Active: " + (BMR * 1.375).ToString();
                label11.Text = "Moderately Active: " + (BMR * 1.55).ToString();
                label12.Text = "Very Active: " + (BMR * 1.725).ToString();
                label13.Text = "Extremely Active: " + (BMR * 1.9).ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }
    }
}
