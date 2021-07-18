using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal minutes;
            Console.WriteLine("Enter your minutes right here:");

            decimal.TryParse(Console.ReadLine(), out minutes);

            Console.WriteLine($"The number of minutes you entered are equal to {(minutes / 60 / 24 / 365).ToString("0.00000")} in years");
            Console.WriteLine($"And {(minutes / 60 / 24).ToString("0.00")} in days");

        }
    }
}
