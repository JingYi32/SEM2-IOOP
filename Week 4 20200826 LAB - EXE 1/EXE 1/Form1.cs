using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE_1
{
    public partial class Form1 : Form
    {
        double totalClicks, jellyfish, koala, penguin, tulip, p;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalClicks += 1;
            tulip += 1;
            double jellyfishPercent = jellyfish / totalClicks;
            double koalaPercent = koala / totalClicks;
            double penguinPercent = penguin / totalClicks;
            double tulipPercent = tulip / totalClicks;
            label2.Text = "Penguin = " + penguinPercent.ToString("P");
            label3.Text = "Jellyfish = " + jellyfishPercent.ToString("P");
            label4.Text = "Koala = " + koalaPercent.ToString("P");
            label5.Text = "Tulip = " + tulipPercent.ToString("P");

            label1.Text = "Total Clicks = " + totalClicks.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalClicks += 1;
            koala += 1;
            double jellyfishPercent = jellyfish / totalClicks;
            double koalaPercent = koala / totalClicks;
            double penguinPercent = penguin / totalClicks;
            double tulipPercent = tulip / totalClicks;
            label2.Text = "Penguin = " + penguinPercent.ToString("P");
            label3.Text = "Jellyfish = " + jellyfishPercent.ToString("P");
            label4.Text = "Koala = " + koalaPercent.ToString("P");
            label5.Text = "Tulip = " + tulipPercent.ToString("P");

            label1.Text = "Total Clicks = " + totalClicks.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalClicks += 1;
            jellyfish += 1;
            double jellyfishPercent = jellyfish / totalClicks;
            double koalaPercent = koala / totalClicks;
            double penguinPercent = penguin / totalClicks;
            double tulipPercent = tulip / totalClicks;
            label2.Text = "Penguin = " + penguinPercent.ToString("P");
            label3.Text = "Jellyfish = " + jellyfishPercent.ToString("P");
            label4.Text = "Koala = " + koalaPercent.ToString("P");
            label5.Text = "Tulip = " + tulipPercent.ToString("P");

            label1.Text = "Total Clicks = " + totalClicks.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalClicks += 1;
            penguin += 1;
            double jellyfishPercent = jellyfish / totalClicks;
            double koalaPercent = koala / totalClicks;
            double penguinPercent = penguin / totalClicks;
            double tulipPercent = tulip / totalClicks;
            label2.Text = "Penguin = " + penguinPercent.ToString("P");
            label3.Text = "Jellyfish = " + jellyfishPercent.ToString("P");
            label4.Text = "Koala = " + koalaPercent.ToString("P");
            label5.Text = "Tulip = " + tulipPercent.ToString("P");

            label1.Text = "Total Clicks = " + totalClicks.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
