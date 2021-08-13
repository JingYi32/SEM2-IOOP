using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_20201014_LAB___EXE_5
{
    class Car
    {
        private int year;
        private string make;
        private double speed;

        //Constructor
        public Car()
        {
            year = 1990;
            make = " ";
            speed = 0;
        }

        //Property
        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public string MAKE
        {
            get { return make; }
            set { make = value; }
        }

        public double SPEED
        {
            get { return speed; }
            set { speed = value; }
        }

        //Method
        public void Accelerate()
        {
            SPEED = SPEED + 5;
        }

        public void Brake()
        {
            SPEED = SPEED - 5;
        }
    }
}
