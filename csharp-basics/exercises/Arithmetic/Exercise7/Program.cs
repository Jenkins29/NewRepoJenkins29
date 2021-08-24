using System;
using Exercise8;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string wage1 = WageCalculator.CalculateWage(7.50, 35, "Employee1");
            string wage2 = WageCalculator.CalculateWage(8.20, 47, "Employee2");
            string wage3 = WageCalculator.CalculateWage(10.00, 73, "Employee3");

            Console.WriteLine(wage1);
            Console.WriteLine(wage2);
            Console.WriteLine(wage3);

            Console.ReadKey();
        }
    }
}
