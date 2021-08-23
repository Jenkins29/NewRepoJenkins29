using System;
using System.Text;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            string input;
            int intInput;

            Console.Write("Max value? ");
            input = Console.ReadLine();

            intInput = int.Parse(input);

            for (int i=1; i<=intInput; i++)
            {
                if ((i - 1) % 20 == 0 && (i-1) != 0)
                {
                    Console.WriteLine();                   
                }

                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else 
                {
                    Console.Write(i + " ");
                };
            }
        }
    }
}
