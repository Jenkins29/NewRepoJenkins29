using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers, sum = 0, remainder;

            Console.WriteLine("Enter your numbers");
            int.TryParse(Console.ReadLine(), out numbers);

            while (numbers > 0)
            {
                remainder = numbers % 10;
                sum = sum + remainder;
                numbers = numbers / 10;
            }
            Console.WriteLine($"The sum of the entered digits is {sum}");
        }
    }
}
