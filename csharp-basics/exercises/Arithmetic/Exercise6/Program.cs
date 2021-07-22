using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            CozaLozaWoza();
        }

        static void CozaLozaWoza()
        {
            for (int i = 1; i < 111; i++)
            {
                if ((i-1) % 11 == 0 && (i-1) != 0)
                {
                   Console.WriteLine();
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza" + " ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza" + " ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza" + " ");
                }                
                else { Console.Write($"{i} "); }

            }
            Console.ReadKey();
        }
    }
}
