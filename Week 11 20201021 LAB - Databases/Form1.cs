using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;            //STEP 1
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_11_20201021_LAB___Databases
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();                 //STEP 2
        OleDbCommand cmd = new OleDbCommand();                              //STEP 3

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=20201015LibraryDatabase.mdb;";
            con.Open();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from student where studenttp = '" + txtTP.Text +"'";
            cmd.Connection = con;
            
            //Display in TextBox
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtFName.Text = dr[1].ToString();
                txtLName.Text = dr[2].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            dr.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from student";
            cmd.Connection = con;

            //Display in DataGridView
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE STUDENT SET FirstName = '" + txtFName.Text + "', LastName = '" + txtLName.Text + "' WHERE StudentTP = '" + txtTP.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO STUDENT VALUES('" + txtTP.Text + "', '" + txtFName.Text + "', '" + txtLName.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}
