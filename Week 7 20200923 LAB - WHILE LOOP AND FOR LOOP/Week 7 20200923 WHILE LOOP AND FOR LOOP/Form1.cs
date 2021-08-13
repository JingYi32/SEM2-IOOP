using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_20200923_WHILE_LOOP_AND_FOR_LOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            ////FOR LOOP
            //for (int count = 1; count <= x; count++)
            //{
            //    MessageBox.Show("Hello");
            //}

            //do-while LOOP
            int count = 1;
            do
            {
                MessageBox.Show("Hello");
                count++;
            } while (count <= x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int answer = rand.Next(10);
            MessageBox.Show(answer.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "TP Number";
            button1.Text = "Login";
        }
    }
}
