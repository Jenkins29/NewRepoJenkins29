using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sum = 0;
            int dice;
            Random r = new Random();
            bool isYesNo;

            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Press any key to roll: ");
            Console.ReadKey();

            dice = r.Next(1, 6);
            sum += dice;

            if (dice != 1)
            {
                Console.WriteLine($"You rolled a {dice}. Currently you have {sum} points.");
                Console.WriteLine("Roll again?");
                input = Console.ReadLine();
                isYesNo = (input == "y" || input == "n");

                while (String.IsNullOrEmpty(input) || isYesNo == false)
                {
                    Console.WriteLine("Invalid input, please enter either 'y' or 'n': ");
                    input = Console.ReadLine();
                    isYesNo = (input == "y" || input == "n");
                }

                while (input.ToLower() == "n")
                {
                    Console.WriteLine($"You got {sum} points.");
                    break;
                }

                while (input.ToLower() == "y")
                {
                    dice = r.Next(1, 6);
                    if (dice != 1)
                    {
                        sum += dice;
                        Console.WriteLine($"You rolled a {dice}. Currently you have {sum} points.");
                        Console.WriteLine("Roll again?");
                        input = Console.ReadLine();
                        isYesNo = (input == "y" || input == "n");

                        while (String.IsNullOrEmpty(input) || isYesNo == false)
                        {
                            Console.WriteLine("Invalid input, please enter either 'y' or 'n': ");
                            input = Console.ReadLine();
                            isYesNo = (input == "y" || input == "n");
                        }

                        if (input == "n")
                        {
                            Console.WriteLine($"You got {sum} points.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You rolled a {dice}!");
                        Console.WriteLine("Game Over. You got 0 points.");
                        break;
                    }
                }
            } 
            else
            {
                Console.WriteLine($"You rolled a {dice}!");
                Console.WriteLine("Game Over. You got 0 points.");
            }
        }     
    }
}
