using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneBook = new PhoneDirectory();
            phoneBook.AddNewNumber("Janis Lazdans", "29988774");
            phoneBook.AddNewNumber("Janis Berzins", "26589547");
            phoneBook.AddNewNumber("Janis Liepins", "26958741");
            phoneBook.AddNewNumber("Janis Zarins", "29548765");
            phoneBook.AddNewNumber("Janis Karins", "27775484");

            phoneBook.PrintContacts();

            Console.ReadLine();
        }
    }
}
