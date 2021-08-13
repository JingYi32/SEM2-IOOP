using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9_20201008_LAB___Multiper_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }

        public string LABEL1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
