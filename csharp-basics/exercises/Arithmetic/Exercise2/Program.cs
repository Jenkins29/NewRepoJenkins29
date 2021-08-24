using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string [] args)
        {
            int number; 
            
            Console.WriteLine("Input your number and I'll tell you more about it:");
            int.TryParse(Console.ReadLine(), out number);

            var result = OddOrEven.CheckIfNumberIsOddOrEven(number);
            var bye = OddOrEven.PrintByeWhenExiting();

            Console.WriteLine(result);
            Console.WriteLine(bye);

            Console.ReadKey();
        }
    }
}
