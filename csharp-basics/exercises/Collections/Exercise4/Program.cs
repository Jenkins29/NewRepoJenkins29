using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number");
            var input = Console.ReadLine();

            int number;
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }
            number = int.Parse(input);
            
            if (IsHappy(number)) Console.WriteLine($"{number} is happy");
            else Console.WriteLine($"{number} is not happy");
            Console.ReadKey();
        }

        private static bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
                
            }
            else if (n == 0 || n == 4)
            {
                return false;
            }
            else return IsHappy(SumSquares(n));
        }

        private static int SumSquares(int n)
        {
            if (n < 10)
            {
                return n * n;
            }
            else
            {
                return SumSquares(n % 10) + SumSquares(n / 10);
            }
        }
    }
}
