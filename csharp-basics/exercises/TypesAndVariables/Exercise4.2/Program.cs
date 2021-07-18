using System;

namespace Exercise4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int birthYear;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your year of birth");
            int.TryParse(Console.ReadLine(), out birthYear);

            Console.WriteLine($"My name is {name} and I was born in {birthYear}");
            

        }
    }
}
