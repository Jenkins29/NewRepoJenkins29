using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exercise3
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person()
        {
            
        }
        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string GetSetFirstName
        {
            get { return _firstName; }
            set {_firstName = value; }
        }

        public string GetSetLastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string GetSetAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public int GetSetID
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public virtual void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}, {_id} Address: {_address}");
        }
    }
}
