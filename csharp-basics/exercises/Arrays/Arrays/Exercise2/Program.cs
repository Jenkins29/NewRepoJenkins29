using System;

namespace Exercise2
{
    class Program
    {        
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int minNumber, maxNumber, index, last;            
            int sum = 0;
            last = myArray.Length - 1;

            Console.WriteLine("Please enter a min number");
            int.TryParse(Console.ReadLine(), out minNumber);
            index = Array.IndexOf(myArray, minNumber);

            while (index < 0)
            {
                Console.WriteLine("This number is not part of the array, " +
                    $"please enter a number which between {myArray[0]} and {myArray[last]}:");                
                minNumber = int.Parse(Console.ReadLine());
                index = Array.IndexOf(myArray, minNumber);
            }

            Console.WriteLine("Please enter a max number");
            int.TryParse(Console.ReadLine(), out maxNumber);
            index = Array.IndexOf(myArray, maxNumber);

            while (index < 0)
            {
                Console.WriteLine("This number is not part of the array, " +
                    $"please enter a number which between {myArray[0]} and {myArray[last]}:");
                maxNumber = int.Parse(Console.ReadLine());
                index = Array.IndexOf(myArray, maxNumber);
            }

            for (int i=minNumber-1; i<=maxNumber-1; i++) 
            {                
                sum += myArray[i];
            }            

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            }
        }
}
