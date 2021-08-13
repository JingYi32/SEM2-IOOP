using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_20201007_LAB___Properties
{
    class Student
    {
        private string studentName;
        private string studentTP;
        private double examScore;

        public Student()    //Constructor #1
        {
            studentName = "";
            studentTP = "TP0000";
            examScore = 0;
        }

        public Student(string sn, string stp, double es)    //Constructor #2
        {
            studentName = sn;
            studentTP = stp;
            examScore = es;
        }

        public Student(string sn, double es, string stp)    //Constructor #3
        {
            studentName = sn;
            studentTP = stp;
            examScore = es;
        }

        public string STUDENTNAME   //Property
        {
            get { return studentName;  }
            set { studentName = value; }
        }
        public string STUDENTTP   //Property
        {
            get { return studentTP; }
            set { studentTP = value; }
        }
        public double EXAMSCORE   //Property (Same function with Getter and Setter)
        {
            get { return examScore; }
            set { examScore = value; }
        }
        public double getExamScore()    //Getter Metohd
        {
            return examScore;
        }
        public void setExamScore(double es) //Setter Method
        {
            examScore = es;
        }

        public char checkGrade()    // '' = char, "" = string
        {
            if ((examScore >= 80) && (examScore <= 100))
                    return 'A';
            else if ((examScore >= 70) && (examScore <= 79))
                    return 'B';
            else if ((examScore >= 60) && (examScore <= 69))
                    return 'C';
            else if ((examScore >= 50) && (examScore <= 59))
                    return 'D';
            else
                return 'F';
        }
    }
}
