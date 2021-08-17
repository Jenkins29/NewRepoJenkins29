using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet));

            var name = string.Empty;
            Console.WriteLine("Enter names:");
            do
            {
                name = Console.ReadLine();
                mySet.Add(name);

            } while (name != string.Empty);

            Console.WriteLine("Unique name list contains:");
            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            Console.WriteLine("Is mySet empty: ");
            mySet.Clear();
            Console.WriteLine(mySet.Count == 0);
            Console.ReadKey();

            
            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));
            Console.ReadKey();
        }
    }
}
