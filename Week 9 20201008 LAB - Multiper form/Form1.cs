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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mainMenu = new Form2();
            this.Hide();
            mainMenu.Show();  //.ShowDialog is modal form | .Show also can work (modeless form)
            mainMenu.LABEL1 = "C# program"; //mainMenu.label1.Text = "Hello World";
        }
    }
}
