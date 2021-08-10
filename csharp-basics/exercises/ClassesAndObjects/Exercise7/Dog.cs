using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{    class Dog
    {
        public string _name;
        public string _sex;
        public Dog _mother;
        public Dog _father;
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;            
        }

        public string FathersName()
        {
            if (_father == null)
            {
                return "Unknown";
            }
            else
            {
                return _father._name;
            }            
        }

        public bool HasSameMotherAsDog(Dog dog)
        {
            if (_mother == dog._mother) return true;
            else return false;
        }
    }
}
