using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;
            Console.WriteLine("Enter the day number");
            int.TryParse(Console.ReadLine(), out dayNumber);


            if (dayNumber < 0 || dayNumber > 6)
            {
                Console.WriteLine("Not a valid day");
            } else { 
                switch (dayNumber)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;

                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturtday");
                        break;
                }
            }
            Console.ReadKey(true);
        }
    }
}
