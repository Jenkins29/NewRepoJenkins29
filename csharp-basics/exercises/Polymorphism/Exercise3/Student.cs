using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Student : Person
    {
        private double _gpa;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public double GetSetGpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public override void Display()
        {
            Console.WriteLine($"{GetSetFirstName} {GetSetLastName}, ID: {GetSetID}, Address: {GetSetAddress}, GPA: {_gpa.ToString("0.00")} ");
        }

    }
}
