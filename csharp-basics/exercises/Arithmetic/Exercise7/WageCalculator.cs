using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public static class WageCalculator
    {
        public static string CalculateWage(double basePay, int hours, string employee)
        {
            double wage;
            int overtimeHours = hours - 40;
            double overtimeBase = 1.5 * basePay;

            if (basePay < 8.00)
            {
                return $"Can't calculate {employee}'s wage, because the base pay is below the minimum wage.";
            }
            if (overtimeHours > 20)
            {
                return $"Can't calculate {employee}'s wage, because overtime hours exceed 20.";
            }

            if (overtimeHours < 0)
            {
                wage = (basePay * hours);
                return $"{employee}'s salary is {wage.ToString("0.00")}";
            }
            
            wage = (basePay * 40) + ((double)overtimeBase * (double)overtimeHours);
            return $"{employee}'s salary is {wage.ToString("0.00")}";
        }
    }
}
