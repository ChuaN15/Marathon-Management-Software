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
    public partial class Form10 : Form
    {
        public Form10(string text)
        {
            InitializeComponent();

            richTextBox1.Text = text;
            richTextBox1.ReadOnly = true;
        }
    }
}
