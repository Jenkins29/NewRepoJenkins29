using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results
            List<string> cars = new List <string>{ "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();

            HashSet<string> carSet = new HashSet<string>
                {"Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla"};
            foreach (var car in carSet)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
            
            Dictionary<string, string> carDictionary = new Dictionary<string, string>()
            {
                {"Audi", "Germany"},
                {"BMW", "Germany"},
                {"Honda", "Japan"},
                {"Mercedes", "Germany"},
                {"Volkswagen", "Germany"},
                {"Tesla", "USA"}
            };
            foreach (KeyValuePair<string, string> carPair in carDictionary)
            {
                Console.WriteLine("Brand name: {0}, Origination country: {1}", carPair.Key, carPair.Value);
            }

            Console.ReadKey();
        }
    }
}
