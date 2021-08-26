
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GravityCalculators.CalculatePositionAfter10SecFallTime();

            Console.WriteLine("The object's position after 10 seconds is " + result + " m.");
            Console.ReadKey();
        }
    }
}
