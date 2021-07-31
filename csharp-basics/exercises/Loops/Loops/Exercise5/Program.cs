using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, input2;

            Console.WriteLine("Enter first word: ");
            input = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            input2 = Console.ReadLine();

            Console.Write($"{input}");

            for (int i =0; i<(30 - input.Length - input2.Length); i++)
            {
                Console.Write(".");
            }

            Console.Write($"{input2}");
            Console.ReadKey();
        }
    }
}
