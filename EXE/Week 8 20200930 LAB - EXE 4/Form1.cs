using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_20200930_LAB___EXE_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cal_f = FatCalories(int.Parse(textBox1.Text));
            label3.Text = "Calories from Fat:\r\n" + cal_f.ToString();
        }

        private int FatCalories(int fat)
        {
            return fat * 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cal_f = CarbCalories(int.Parse(textBox1.Text));
            label4.Text = "Calories from Carbohydrate:\r\n" + cal_f.ToString();
        }

        private int CarbCalories(int carb)
        {
            return carb * 4;
        }
    }
}
