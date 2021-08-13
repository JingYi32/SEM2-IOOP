using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_10_20201014_LAB___EXE_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Car car = new Car();
        private void btnAcc_Click(object sender, EventArgs e)
        {
            car.Accelerate();
            lblCurrent.Text = "Current Speed of the Car:    " + car.SPEED + "km/h"; 
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            car.Brake();
            lblCurrent.Text = "Current Speed of the Car:    " + car.SPEED + "km/h";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblShowMake.Text = "Make                    :   " + txtMake.Text;
            lblShowYear.Text = "Year                    :   " + txtYear.Text;
            lblCurrent.Text = "Current Speed of the Car :   0 km/h";
        }
    }
}
