using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_2
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
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((username == "admin") && (password == "admin"))
                MessageBox.Show("Login successful");
            else
                MessageBox.Show("Login failed");


            //int number;
            //if (int.TryParse(textBox1.Text, out number))
            //    MessageBox.Show(number.ToString());
            //else
            //    MessageBox.Show("Invalid input");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Male");
            else if (radioButton2.Checked)
                MessageBox.Show("Female");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (checkBox2.Checked)
                price = price + 3.5;

            if (checkBox3.Checked)
                price = price + 2.5;

            if (checkBox4.Checked)
                price = price + 4.5;

            MessageBox.Show(price.ToString());

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double grade = double.Parse(textBox3.Text);
            if ((grade >= 80) && (grade <= 100))
            {
                MessageBox.Show("A");
            }
            else if (grade >= 70)
            {
                MessageBox.Show("B");
            }
            else if (grade >= 60)
            {
                MessageBox.Show("C");
            }
            else if (grade >= 50)
            {
                MessageBox.Show("D");
            }
            else
            {
                MessageBox.Show("F");
            }
        }
    }
}
