using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_13_20201104_Lab___Exe_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int[] numbers = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            totalArray(numbers);
            LargestIndex(numbers, 100);
            Largest(numbers);
            Smallest(numbers);
        }

        private void addArray(int[] Array)
        {
            for (int index = 0; index<10; index++)
            if (Array.Length < 10)
            {
                Array[index] = int.Parse(textBox1.Text);
            }
        }

        private void totalArray(int[] sArray)
        {
            int total = 0;
            for (int index = 0; index < sArray.Length; index++)
            {
                total = total + sArray[index];
            }
            lblTotal.Text = total.ToString();
        }

        private void LargestIndex(int[] array, int value)
        {
            bool found = false;
            int index = 0;
            int position = -1;
            while (!found && index < array.Length)
            {
                if (array[index] == value)
                {
                    found = true;
                    position = index;
                }
                index++;
            }
            lblLargest_Index.Text = index.ToString();
        }

        private void Largest(int[] array)
        {
            int number = array[1];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > number)
                {
                    number = array[index];
                }
            }
            lblLargest.Text = number.ToString();
        }

        private void Smallest(int[] array)
        {
            int number = array[1];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < number)
                {
                    number = array[index];
                }
            }
            lblSmallest.Text = number.ToString();
        }
    }
}
