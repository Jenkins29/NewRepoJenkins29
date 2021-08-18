using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public string GetSetJobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public override void Display()
        {
            Console.WriteLine($"{GetSetFirstName} {GetSetLastName}, ID: {GetSetID} Address: {GetSetAddress}, Job Title: {_jobTitle}");
        }
    }
}
