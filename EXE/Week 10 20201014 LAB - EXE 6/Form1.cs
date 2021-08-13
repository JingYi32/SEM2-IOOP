using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_10_20201014_LAB___EXE_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtName.Clear();
            txtID.Clear();
            txtDepartment.Clear();
            txtPosition.Clear();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.NAME = txtName.Text;
            emp1.IDNUMBER = int.Parse(txtID.Text);
            emp1.DEPARTMENT = txtDepartment.Text;
            emp1.POSITION = txtPosition.Text;

            lblemp1n.Text = emp1.NAME;
            lblemp1id.Text = emp1.IDNUMBER.ToString();
            lblemp1d.Text = emp1.DEPARTMENT;
            lblemp1p.Text = emp1.POSITION;
            Clear();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            Employee emp2 = new Employee();
            emp2.NAME = txtName.Text;
            emp2.IDNUMBER = int.Parse(txtID.Text);
            emp2.DEPARTMENT = txtDepartment.Text;
            emp2.POSITION = txtPosition.Text;

            lblemp2n.Text = emp2.NAME;
            lblemp2id.Text = emp2.IDNUMBER.ToString();
            lblemp2d.Text = emp2.DEPARTMENT;
            lblemp2p.Text = emp2.POSITION;
            Clear();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Employee emp3 = new Employee();
            emp3.NAME = txtName.Text;
            emp3.IDNUMBER = int.Parse(txtID.Text);
            emp3.DEPARTMENT = txtDepartment.Text;
            emp3.POSITION = txtPosition.Text;

            lblemp3n.Text = emp3.NAME;
            lblemp3id.Text = emp3.IDNUMBER.ToString();
            lblemp3d.Text = emp3.DEPARTMENT;
            lblemp3p.Text = emp3.POSITION;
            Clear();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Employee emp4 = new Employee();
            emp4.NAME = txtName.Text;
            emp4.IDNUMBER = int.Parse(txtID.Text);
            emp4.DEPARTMENT = txtDepartment.Text;
            emp4.POSITION = txtPosition.Text;

            lblemp4n.Text = emp4.NAME;
            lblemp4id.Text = emp4.IDNUMBER.ToString();
            lblemp4d.Text = emp4.DEPARTMENT;
            lblemp4p.Text = emp4.POSITION;
            Clear();
        }
    }
}
