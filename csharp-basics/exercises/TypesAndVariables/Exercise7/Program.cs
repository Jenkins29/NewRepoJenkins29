using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            int count = 0;

            Console.WriteLine("Enter your string here");
            myString = Console.ReadLine();

            for (int i=0; i<myString.Length; i++)
            {
                if (char.IsUpper(myString[i])) count++;
            }

            Console.WriteLine($"The entered string contains {count} upper-case characters");

        }
    }
}
