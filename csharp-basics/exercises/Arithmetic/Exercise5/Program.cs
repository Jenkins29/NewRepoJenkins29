using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, input;
            Random randNumber = new Random();
            n = randNumber.Next(1, 100);

            Console.WriteLine("I am thinking of a number between 1-100. Try to guess it.");
            int.TryParse(Console.ReadLine(), out input);

            if (input == n) Console.WriteLine("You guessed it!  What are the odds?!?");
            if (input < n) Console.WriteLine($"Sorry, you are too low.  I was thinking of {n}.");
            if(input > n) Console.WriteLine($"Sorry, you are too high.  I was thinking of {n}.");

            Console.ReadKey();

        }
    }
}
