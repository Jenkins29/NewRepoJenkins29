using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {            
            int input;
            Random r = new Random();
            Random r2 = new Random();
            int sum = 0;

            Console.Write("Desired sum: ");
            int.TryParse(Console.ReadLine(), out input);

            if(input < 1 || input > 12 || String.IsNullOrEmpty(input.ToString()))
            {
                Console.Write("Invalid sum, please enter a number between 1 and 12: ");
                int.TryParse(Console.ReadLine(), out input);

                while (input < 1 || input > 12 || String.IsNullOrEmpty(input.ToString()))
                {
                    Console.Write("Invalid sum, please enter a number between 1 and 12: ");
                    int.TryParse(Console.ReadLine(), out input);
                }
            }

            while (sum != input)
            {
                int random1 = r.Next(1, 7);
                int random2 = r2.Next(1, 7);
                sum = random1 + random2;
                Console.WriteLine($"{random1} and {random2} = {sum}");
            }

            Console.ReadKey();
        }
    }
}
