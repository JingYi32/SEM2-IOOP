using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_20201014_LAB___EXE_6
{
    class Employee
    {
        private string name;
        private int IdNumber;
        private string position;
        private string department;

        //Cons
        public Employee()
        {
            name = "";
            IdNumber = 0;
            position = "";
            department = "";
        }

        //Property
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int IDNUMBER
        {
            get { return IdNumber; }
            set { IdNumber = value; }
        }
        public string POSITION
        {
            get { return position; }
            set { position = value; }
        }
        public string DEPARTMENT
        {
            get { return department; }
            set { department = value; }
        }
    }
}
