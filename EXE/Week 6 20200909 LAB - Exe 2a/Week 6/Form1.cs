using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked) && (radioButton4.Checked))
                BackColor = Color.Red;
            else if ((radioButton2.Checked) && (radioButton5.Checked))
                BackColor = Color.Blue;
            else if ((radioButton3.Checked) && (radioButton6.Checked))
                BackColor = Color.Yellow;
            else if (((radioButton1.Checked) && (radioButton5.Checked)) || ((radioButton2.Checked) && (radioButton4.Checked)))
                BackColor = Color.Purple;
            else if (((radioButton1.Checked) && (radioButton6.Checked)) || ((radioButton3.Checked) && (radioButton4.Checked)))
                BackColor = Color.Orange;
            else if (((radioButton3.Checked) && (radioButton5.Checked)) || ((radioButton2.Checked) && (radioButton6.Checked)))
                BackColor = Color.Green;
            else
                MessageBox.Show("Wrong Input");
        }
    }
}
