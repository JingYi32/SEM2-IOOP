using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8_20201001_LEC___Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();
            myCoin.Toss();
            ShowCoinStatus(myCoin);
        }

        private void ShowCoinStatus(Coin coin)
        {
            MessageBox.Show("Side is " + coin.getSideUP());
        }
    }
}
