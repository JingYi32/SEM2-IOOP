using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_20200903_Lec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SWITCH
            int month=int.Parse(textBox1.Text);

            switch (month)
            {
                case 1:
                    MessageBox.Show("January");
                    break;
                case 2:
                    MessageBox.Show("February");
                    break;
                case 3:
                    MessageBox.Show("March");
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add items into combox by coding
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear all items in the listbox
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ////clear specific item
            //listBox1.Items.RemoveAt(0);                           //remove the first item
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
