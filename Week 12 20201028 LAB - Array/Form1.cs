using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;

            //same with code below
            int[] numbers = { 10, 20, 30, 40, 50 };

            ////Pop-up only one message box
            //MessageBox.Show(numbers[3].ToString());

            //Pop-up multiple message box
            for (int index = 0; index<numbers.Length; index++)
            {
                MessageBox.Show(numbers[index].ToString());
                if (numbers[index] >= 5) 
            }

            foreach (double element in numbers)
            {
                MessageBox.Show(element.ToString());
            }
            showArray(numbers);
        }

        private void showArray(double[] array1)
        {
            foreach (double element in array1)
            {
                MessageBox.Show(element.ToString());
            }
        }

        private void showArray2(double[] array2, double value)
        {
            bool found = false;
            int index = 0;
            int position = -1;
            while (!found && index < array2.Length)
            {
                if (array2[index] == value)
                {
                    found = true;
                    position = index;
                }
                index++;
            }
        }

        private void totalArray(double[] sArray)
        {
            double total = 0;
            for (int index = 0; index < sArray.Length; index++)
            {
                total = total + sArray[index];
            }
            double avg = total / sArray.Length;
        }
    }
}
