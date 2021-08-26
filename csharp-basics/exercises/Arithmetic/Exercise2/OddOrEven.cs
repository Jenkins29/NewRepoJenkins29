using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public static class OddOrEven
    {
        public static string CheckIfNumberIsOddOrEven(int number)
        {
            if (number % 2 == 0) return "Even Number";
            else return "Odd Number";
        }

        public static string PrintByeWhenExiting()
        {
            return "bye!";
        }
    }
}
