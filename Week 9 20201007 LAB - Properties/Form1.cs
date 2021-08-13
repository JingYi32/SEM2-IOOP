using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9_20201007_LAB___Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string un)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student stud1 = new Student();
            Student stud2 = new Student();
            Student stud3 = new Student("Yap", "TP01234", 90);  //Call 2nd constuctor
            stud1.setExamScore(68);
            stud2.EXAMSCORE = 88;
            stud2.STUDENTNAME = "Kar Hou";
            MessageBox.Show(stud1.checkGrade().ToString());
            MessageBox.Show(stud3.EXAMSCORE.ToString());
        }
    }
}
