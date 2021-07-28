using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] myArray1 = new int[10];
            int[] myArray2 = new int[10];

            for (int i=0; i<myArray1.Length; i++)
            {
               myArray1[i] = r.Next(0,100);
            }

            Array.Copy(myArray1, 0, myArray2, 0, myArray1.Length);

            myArray1[myArray1.Length - 1] = -7;

            Console.Write("Array 1: ");            
            foreach (int number in myArray1)
            {
               Console.Write($"{number} ");
            }
            
            Console.WriteLine();

            Console.Write("Array 2: ");
            foreach (int number in myArray2)
            {
               Console.Write($"{number} ");
            }

            Console.ReadKey();
        }
    }
}
