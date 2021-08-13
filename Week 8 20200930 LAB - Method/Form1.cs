using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8_20200930_LAB___Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Naming Argument
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 5, num2 = 10;
            displayMessage(value2: num1, value1: num2);
        }

        public void displayMessage(int value1, double value2)
        {
            MessageBox.Show("Indise displayMessage2 method.");
            MessageBox.Show(value2.ToString());
        }

        //Pass by Value
        private void button2_Click(object sender, EventArgs e)
        {
            int value = 100;
            setToZero1(value);
            MessageBox.Show(value.ToString());
        }

        private void setToZero1 (int number)
        {
            number = 0;
        }

        //Pass by Reference
        private void button3_Click(object sender, EventArgs e)
        {
            int value = 100;
            setToZero2(ref value);
            MessageBox.Show(value.ToString());
        }

        private void setToZero2(ref int number)
        {
            number = 0;
        }

        //Output Parameter
        private void button4_Click(object sender, EventArgs e)
        {
            int value; 
            setToZero3(out value);
            MessageBox.Show(value.ToString());
        }
        private void setToZero3(out int number)
        {
            number = 0;
        }

        //value-returning
        private void button5_Click(object sender, EventArgs e)
        {
            double mean = calcAvg(6, 3);
            MessageBox.Show(mean.ToString());
        }

        private double calcAvg(double num1, double num2)
        {
            double avg = num1 / num2;
            return avg;
        }

        //Boolean Methods
        private void button6_Click(object sender, EventArgs e)
        {
            if (IsEven(23))
                MessageBox.Show("Even number");
            else
                MessageBox.Show("Odd number");
        }

        private bool IsEven(int number)
        {
            bool numberIsEven;
            if (number % 2 == 0)
            {
                numberIsEven = true;
            }
            else
            {
                numberIsEven = false;
            }
            return numberIsEven;
        }
    }
}
