using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public string _name;
        public string _number;
        public SortedDictionary<string, string> PhoneEntries = new SortedDictionary<string, string>();

        public void FindNumber(string name)
        {
            _name = name;
            for (var i = 0; i < PhoneEntries.Count; i++)
            {
                if (PhoneEntries.ContainsKey(name))
                {
                    Console.WriteLine($"{name}'s phone number is {PhoneEntries.Values.ElementAt(i)}");
                }
                else
                {
                    Console.WriteLine($"No number with the name {name} was found.");
                }
            }
        }

        public void FindName(string number)
        {
            _number = number;
            for (var i = 0; i < PhoneEntries.Count; i++)
            {
                if (PhoneEntries.ContainsValue(number))
                {
                    Console.WriteLine($"The name found under number {number} is: {PhoneEntries.Keys.ElementAt(i)}");
                }
                else
                {
                    Console.WriteLine($"Number {number} was not found in your directory.");
                }
            }
        }

        public void AddNewNumber(string name, string number)
        {
            _name = name;
            _number = number;

            PhoneEntries.Add(_name, _number);
        }

        public void PrintContacts()
        {
            foreach (KeyValuePair<string, string> entry in PhoneEntries)
            {
                Console.WriteLine($"Name: {entry.Key}, number: {entry.Value} ");
            }
        }
    }
}