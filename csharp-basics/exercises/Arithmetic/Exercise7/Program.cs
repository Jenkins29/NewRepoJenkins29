using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            WageCalculator(7.50, 35, "Employee1");
            WageCalculator(8.20, 47, "Employee2");
            WageCalculator(10.00, 73, "Employee3");
        }

        static void WageCalculator(double basePay, int hours, string employee)
        {
            int overtimeHours;
            double wage, overtimeBase;

            overtimeHours = hours - 40;
            overtimeBase = 1.5 * basePay;

            if (basePay < 8.00)
            {
                Console.WriteLine($"Can't calculate {employee}'s wage, because the base pay is below the minimum wage.");
            }
            else if (overtimeHours <= 0)
            {
                wage = basePay * (double)hours;
                Console.WriteLine($"Based on the base pay and worked hours, {employee}'s salary is {wage.ToString("0.00")}");
            }
            else if (overtimeHours > 20)
            {
                Console.WriteLine($"Can't calculate {employee}'s wage, because overtime hours exceed 20.");
            }
            else
            {
                wage = (basePay * 40) + ((double)overtimeBase * (double)overtimeHours);
                Console.WriteLine($"Based on the base pay and worked hours, {employee}'s salary is {wage.ToString("0.00")}");
            }

            Console.ReadKey();

        }
    }
}
