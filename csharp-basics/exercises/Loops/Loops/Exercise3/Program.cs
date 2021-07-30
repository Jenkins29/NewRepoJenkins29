using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] myArray = new int[20];
            int index, input2;
            string input;

            for (int i = 0; i<20; i++)
            {
                myArray[i] = r.Next(0, 100);
                Console.Write(myArray[i]+ ", ");
                if (i == 19)
                {
                    Console.Write(myArray[i]);
                }
            }            

            Console.WriteLine();
            Console.WriteLine("Choose a number and I will return the index of its first occurance:");
            input = Console.ReadLine();

            while (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input, try again:");
                input = Console.ReadLine();
            }

            input2 = int.Parse(input);
            index = Array.IndexOf(myArray, input2);

            while (index < 0)
            {
                Console.WriteLine("This number is not part of the available numbers, please chose again:");
                input = Console.ReadLine();

                while (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input, try again:");
                    input = Console.ReadLine();
                }
                input2 = int.Parse(input);
                index = Array.IndexOf(myArray, input2);
            }

            Console.WriteLine($"The index of {input} is: {index}");            
        }
    }
}
