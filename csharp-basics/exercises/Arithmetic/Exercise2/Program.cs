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

            if (number % 2 == 0) Console.WriteLine("This number is even");
            if (number % 2 != 0) Console.WriteLine("This number is odd");

            Console.ReadKey();
            Console.WriteLine("bye!");

            

            
        }

    }
}
