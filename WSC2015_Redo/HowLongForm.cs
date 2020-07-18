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
    public partial class HowLongForm : Form
    {
        public static List<Speed> speedlist = new List<Speed>();
        public static List<Distance> distancelist = new List<Distance>();
        public HowLongForm()
        {
            InitializeComponent();

            speedlist.Add(new Speed { name = "F1 Car", image = "f1-car.jpg", speed = 345 });
            speedlist.Add(new Speed { name = "Slug", image = "slug.jpg", speed = 0.01 });
            speedlist.Add(new Speed { name = "Horse", image = "horse.png", speed = 15 });
            speedlist.Add(new Speed { name = "Sloth", image = "sloth.jpg", speed = 0.12 });
            speedlist.Add(new Speed { name = "Capybara", image = "capybara.jpg", speed = 35 });
            speedlist.Add(new Speed { name = "Jaguar", image = "jaguar.jpg", speed = 80 });
            speedlist.Add(new Speed { name = "Worm", image = "worm.jpg", speed = 0.03 });
            
            distancelist.Add(new Distance { name = "Bus", image = "bus.jpg", length = 10 });
            distancelist.Add(new Distance { name = "Pair of Havaianas", image = "pair-of-havaianas.jpg", length = 0.245 });
            distancelist.Add(new Distance { name = "Airbus A380", image = "airbus-a380.jpg", length = 73 });
            distancelist.Add(new Distance { name = "Football Field", image = "football-field.jpg", length = 105 });
            distancelist.Add(new Distance { name = "Ronaldinho", image = "ronaldinho.jpg", length = 1.81 });

            foreach (var item in speedlist)
            {
                flowLayoutPanel2.Controls.Add(new UserControl1(this, item.name, item.image));
            }

            foreach (var item in distancelist)
            {
                flowLayoutPanel1.Controls.Add(new UserControl1(this, item.name, item.image));
            }
        }

        public void loadSelected(string text)
        {
            if(speedlist.FirstOrDefault(x => x.name == text) != null)
            {
                var whichdata = speedlist.FirstOrDefault(x => x.name == text);
                pictureBox1.Image = Image.FromFile(whichdata.image);

                double x2 = whichdata.speed / 60.00;
                double reach = 42 / x2;
                TimeSpan ts = TimeSpan.FromMinutes(reach);

                label3.Text = "The top speed of a " + whichdata.name + " is " + whichdata.speed.ToString() + "km/h. It would take " + ts.Days + "days " + ts.Hours + "hours " + ts.Minutes + "minutes to complete a 42km marathon.";
            }
            else
            {
                var whichdata = distancelist.FirstOrDefault(x => x.name == text);
                pictureBox1.Image = Image.FromFile(whichdata.image);

                double x2 = whichdata.length;
                double reach = 42000 / x2;

                label3.Text = "The length of a " + whichdata.name + " is " + whichdata.length.ToString() + "m. It would take " + reach.ToString("00.00") + " of them to cover the track of a 42km marathon.";
            }

        }
    }
}
