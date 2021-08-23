using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date today = new Date();

            today.Day = 2;
            today.Month = 8;
            today.Year = 2021;

            Console.Write("Today's date is: ");
            today.DisplayDate();

            Console.ReadKey();
            
        }
    }
}
