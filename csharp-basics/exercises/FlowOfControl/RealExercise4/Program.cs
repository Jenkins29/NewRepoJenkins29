using System;

namespace RealExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "dummyDay", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturtday"};
            int dayNumber;

            Console.WriteLine("Please input your day number here:");
            int.TryParse(Console.ReadLine(), out dayNumber);

            if (dayNumber < 6)
            {
                if (dayNumber == 0) Console.WriteLine("Not a valid day");

                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine(days[dayNumber]); break;
                    case 2:
                        Console.WriteLine(days[dayNumber]); break;
                    case 3:
                        Console.WriteLine(days[dayNumber]); break;
                    case 4:
                        Console.WriteLine(days[dayNumber]); break;
                    case 5:
                        Console.WriteLine(days[dayNumber]); break;
                    case 6:
                        Console.WriteLine(days[dayNumber]); break;
                    case 7:
                        Console.WriteLine(days[dayNumber]); break;
                }
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }
            Console.ReadKey();
        }
    }
}
