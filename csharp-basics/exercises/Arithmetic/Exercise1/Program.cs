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

            if (CheckFor15.CheckIfNumberDifferenceIs15(number1, number2) ||
                CheckFor15.CheckIfNumberIs15(number1, number2) ||
                CheckFor15.CheckIfNumberSumIs15(number1, number2))
            {
                is15 = true;
                Console.WriteLine(is15);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
