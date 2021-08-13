using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_20200924_LEC_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Before Call");
            displayMessage1();   //Call statement
            MessageBox.Show("After Call");
            displayMessage2(5, 10);
        }

        public void displayMessage1()
        {
            MessageBox.Show("Indise displayMessage1 method.");
        }

        public void displayMessage2(int value1, double value2)
        {
            MessageBox.Show("Indise displayMessage2 method.");
            MessageBox.Show(value1.ToString());
            MessageBox.Show(value2.ToString());
        }

    }
}
