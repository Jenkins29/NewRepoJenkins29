using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            int input1, input2, input3;

            Console.WriteLine("Input the 1st number: ");
            int.TryParse(Console.ReadLine(), out input1);

            Console.WriteLine("Input the 2nd number: ");
            int.TryParse(Console.ReadLine(), out input2);

            Console.WriteLine("Input the 3rd number: ");
            int.TryParse(Console.ReadLine(), out input3);

            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"{input1} is the largest number");
            }

            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine($"{input2} is the largest number");
            }
            else if (input3 > input2 && input3 > input1)
            {
                Console.WriteLine($"{input3} is the largest number");
            }
            else
            {
                Console.WriteLine("All of the input numbers are the same, can't execute");
            }
        }
    }
}
