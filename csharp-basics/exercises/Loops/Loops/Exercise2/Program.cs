using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i < n; i++)
            {
              Console.WriteLine(Pow(i,n));
            }

            Console.ReadKey();
        }

        static int Pow(int arg, int arg2)
        {
            int result = 1;

            for (int i=0; i<arg2; i++)
            {
                result *= arg;
            }

            return result;                       
        }
    }
}
