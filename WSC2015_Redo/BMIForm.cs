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
    public partial class BMIForm : Form
    {
        Brush[] brush2 = new Brush[] { Brushes.Yellow, Brushes.Green, Brushes.Yellow, Brushes.Red };
        Bitmap bm;
        Graphics g;
        public BMIForm()
        {
            InitializeComponent();

            bm = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            g = Graphics.FromImage(bm);

            double ans =pictureBox6.Width/400.00;
            
            g.FillRectangle(brush2[0], new Rectangle(0, 0, (int)(100.00*ans), pictureBox6.Height));
            g.FillRectangle(brush2[1], new Rectangle(100, 0, (int)(100.00 * ans), pictureBox6.Height));
            g.FillRectangle(brush2[2], new Rectangle(200, 0, (int)(100.00 * ans), pictureBox6.Height));
            g.FillRectangle(brush2[3], new Rectangle(300, 0, (int)(100.00 * ans), pictureBox6.Height));

            pictureBox6.Image = bm;

            //trackBar1.Maximum = pictureBox6.Width;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight=0, height = 0;

            if(!double.TryParse(textBox1.Text,out height)|| !double.TryParse(textBox2.Text, out weight))
            {
                MessageBox.Show("Please enter valid value of height and weight!");
                return;
            }

            double BMI = (weight / (height * height * 0.01)*100);

            MessageBox.Show(BMI.ToString());

            label6.Text = BMI.ToString();

            //try
            //{
            //    trackBar1.Value = (int)(pictureBox6.Width * BMI / 100 * 12);
            //}
            //catch (Exception)
            //{
            //    trackBar1.Value = trackBar1.Maximum;
            //}
            

            if(BMI < 18.5)
            {
                pictureBox5.Image = Image.FromFile("bmi-underweight-icon.png");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                pictureBox5.Image = Image.FromFile("bmi-healthy-icon.png");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                pictureBox5.Image = Image.FromFile("bmi-overweight-icon.png");
            }
            else
            {
                pictureBox5.Image = Image.FromFile("bmi-obese-icon.png");
            }

        }

        private void BMIForm_Load(object sender, EventArgs e)
        {

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
    }
}
