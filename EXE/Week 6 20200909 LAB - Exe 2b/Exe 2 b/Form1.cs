using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exe_2_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1;
            string n2;
            n1 = textBox1.Text;
            n2 = textBox2.Text;

            if (int.Parse(n1) > int.Parse(n2))
                label3.Text = "The Larger Number is " + n1;
            else if (int.Parse(n2) > int.Parse(n1))
                label3.Text = "The Larger Number is " + n2;
            else if (int.Parse(n2) == int.Parse(n1))
                label3.Text = "Both are the same";
            else
                label3.Text = "Wrong Input";
        }
    }
}
