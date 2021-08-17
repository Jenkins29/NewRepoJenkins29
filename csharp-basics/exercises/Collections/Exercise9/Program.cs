using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        public static HashSet<string> VeryImportantSet = new HashSet<string>();

        static void Main(string[] args)
        {
            bool continueLoop = true;
            string userInput;

            while (continueLoop)
            {
                Console.WriteLine("Hello User, press any key to start adding your values:");
                Console.ReadLine();
                AddFiveValues();

                Console.WriteLine("Press any key to display the values you've just added:");
                Console.ReadLine();
                DisplayHashset();

                Console.WriteLine("Press any key to clear the hashset:");
                Console.ReadLine();
                RemoveValues();

                Console.ReadLine();
                Console.WriteLine("Press any key to display the hashset now:");
                Console.ReadLine();
                DisplayHashset();

                Console.ReadLine();
                Console.WriteLine("If you want to do this again, enter the letter 'g'");
                userInput = Console.ReadLine();
                if (userInput != "g") continueLoop = false; Console.WriteLine("Program will exit now, BB!");
                Console.Clear();
            }
        }

        static void AddFiveValues()
        {
            string input;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Input value number {i}:");
                input = Console.ReadLine();

                while (VeryImportantSet.Contains(input) && i != 1)
                {
                    Console.WriteLine("This input already exists in the hashset, try something else:");
                    input = Console.ReadLine();
                }
                VeryImportantSet.Add(input);
            }
        }

        static void DisplayHashset()
        {
            if (VeryImportantSet.Count == 0)
            {
                Console.WriteLine("There are no entries to display.");
            }

            foreach (var entry in VeryImportantSet)
            {
                Console.WriteLine(entry + " ");
            }
        }
        static void RemoveValues()
        {
            VeryImportantSet.Clear();
        }
    }
}
