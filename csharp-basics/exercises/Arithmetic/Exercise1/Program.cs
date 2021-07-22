using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2;
            bool is15;

            Console.WriteLine("Please input your first integer:");
            int.TryParse(Console.ReadLine(), out number1) ;

            Console.WriteLine("Please input your second integer:");
            int.TryParse(Console.ReadLine(), out number2);

            if (number1 == 15 || number2 == 15 || number1 + number2 == 15)
            {
                is15 = true;
                Console.WriteLine(is15);
            }
            else
            {
                Console.WriteLine("No 15's anywhere. Nothing to see here, exiting.....");
            }
                
            Console.ReadKey();





        }
    }
}
