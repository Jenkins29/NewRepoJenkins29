using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public static string Name;
        public static string Number;
        public SortedDictionary<string, string> PhoneEntries = new SortedDictionary<string, string>();
        public string FindNumber(string name)
        {
            string result = string.Empty;
            Name = name;

            for (var i = 0; i < PhoneEntries.Count; i++)
            {
                if (PhoneEntries.ContainsKey(name))
                {
                    var number = PhoneEntries[name];
                    result = $"{name}'s phone number is {number}.";
                }
                else result = $"No number with the name {name} was found.";
            }
            return result;
        }

        public string FindName(string number)
        {
            string result = string.Empty;
            Number = number;
            string name = string.Empty;

            for (var i = 0; i < PhoneEntries.Count; i++)
            {
                if (PhoneEntries.ContainsValue(number))
                {
                    name = PhoneEntries.FirstOrDefault(x => x.Value == number).Key;
                    result = $"The name found under number {number} is: {name}";
                }
                else
                {
                    result = $"Number {number} was not found in your directory.";
                }
            }
            return result;
        }

        public void AddNewNumber(string name, string number)
        {
            Name = name;
            Number = number;
            PhoneEntries.Add(Name, Number);
        }

        public string PrintContacts()
        {
            string result = string.Empty;

            foreach (KeyValuePair<string, string> entry in PhoneEntries)
            {
                result += $"Name: {entry.Key}, number: {entry.Value} " + "\n";
            }
            return result;
        }
    }
}