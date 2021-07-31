using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            int min, max;

            Console.Write("Min?: ");            
            
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.Write("Invalid input, input a valid number: ");                
            }           

            Console.Write("Max?: ");

            while (!int.TryParse(Console.ReadLine(), out max) || max < min)
            {
                Console.Write("Invalid input, input a valid number which is larger than the 'min' number: ");
            }

            for (int i=min; i<=max; i++)
            {
                for (int x=i; x<=max; x++)
                {
                    Console.Write(x);
                }

                for (int j=min; j<i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
