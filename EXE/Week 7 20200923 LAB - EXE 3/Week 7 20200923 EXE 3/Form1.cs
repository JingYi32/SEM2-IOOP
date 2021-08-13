using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_20200923_EXE_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate Factorial
            int x = int.Parse(textBox1.Text);
            int novation=1;
            for (int number = 1; number <= x; number++)
            {
                novation = novation * number;
            }
            MessageBox.Show(novation.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate Harmoric Sum
            double x = int.Parse(textBox2.Text);
            double sum = 1;
            for (double number = 1; number <= x; number++)
            {
                sum = sum + 1/number;
            }
            MessageBox.Show(sum.ToString());

            ////do-while LOOP
            //double total2 = 0;
            //double number = double.Parse(textBox2.Text);
            //do
            //{
            //    double number2 = 1 / number;
            //    total2 = total2 + number2;
            //    number--;
            //} while (number != 0);

            //MessageBox.Show(sum.ToString());
            //}
        }
    }
}
