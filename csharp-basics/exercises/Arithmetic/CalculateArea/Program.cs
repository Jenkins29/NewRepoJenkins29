using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            
            do
            {
                int userChoice;

                // Display the menu.
                Console.WriteLine("Geometry Calculator\n");
                Console.WriteLine("1. Calculate the Area of a Circle");
                Console.WriteLine("2. Calculate the Area of a Rectangle");
                Console.WriteLine("3. Calculate the Area of a Triangle");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("Enter your choice (1-4) : ");
                var inputKey = Console.ReadKey();

                // get input from user
                int.TryParse(inputKey.KeyChar.ToString(), out userChoice);

                // validate input
                while (userChoice < 1 || userChoice > 4)
                {
                    Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                    inputKey = Console.ReadKey();
                    int.TryParse(inputKey.KeyChar.ToString(), out userChoice);
                }

                choice = userChoice;

                if (choice == 1)
                {
                    // Get input from user
                    Console.WriteLine("What is the circle's radius? ");

                    var keyboard = Console.ReadLine();

                    decimal.TryParse(keyboard, out var radius);

                    // Display output
                    Console.WriteLine("The circle's area is "
                                      + Geometry.AreaOfCircle(radius));
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    decimal length, width;

                    // Get input from user
                    // Get length
                    Console.WriteLine("Enter length? ");
                    decimal.TryParse(Console.ReadLine(), out length);

                    // Get width
                    Console.WriteLine("Enter width? ");
                    decimal.TryParse(Console.ReadLine(), out width);

                    // Display output
                    Console.WriteLine("The rectangle's area is "
                                      + Geometry.AreaOfRectangle(length, width));
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    decimal ground, height;

                    // Get input from user
                    var keyboard = Console.ReadKey();

                    // Get the base
                    Console.WriteLine("Enter length of the triangle's base? ");
                    decimal.TryParse(Console.ReadLine(), out ground);

                    // Get the height
                    Console.WriteLine("Enter triangle's height? ");
                    decimal.TryParse(Console.ReadLine(), out height);

                    // Display the triangle's area.
                    Console.WriteLine("The triangle's area is "
                                      + Geometry.AreaOfTriangle(ground, height));
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }
    }
}
