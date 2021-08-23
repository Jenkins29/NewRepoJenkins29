using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN();
        }

        static void Product1ToN()
        {
            var multSum = 1;

            for (int i=1; i<=10; i++)
            {
                multSum *= i;
            }

            Console.WriteLine(multSum);
            Console.ReadKey();
        }
    }
}
