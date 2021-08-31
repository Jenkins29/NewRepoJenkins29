using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool wantToContinue = true;

            FlightCoordinator.ReadFileInto2TempLists(FlightCoordinator.Path, FlightCoordinator.FlightsList, FlightCoordinator.TempFlightList);
            Console.WriteLine(FlightCoordinator.ShowStartMenu());

            string[] userInputs = { "1", "#" };
            var input = Console.ReadLine();

            while (!userInputs.Contains(input))
            {
                Console.WriteLine("Invalid input, please try again");
                input = Console.ReadLine();
            }

            if (input == "#")
            {
                Console.WriteLine("Program will exit now, good bye");
                Console.ReadKey();
                wantToContinue = false;
            }
            else
            {
                Console.WriteLine("Input the corresponding number of the flight you would like to start with:");
                Console.WriteLine(FlightCoordinator.DisplayStartingCities(FlightCoordinator.FlightsList));
            }

            while (wantToContinue)
            {
                var userInput = Console.ReadLine();
                int flightNumber = ValidateInput(userInput);
                if (flightNumber == 0) break;
                
                var fly = FlightCoordinator.TempFlightList[flightNumber - 1].Replace(" -> ", "|").Split('|')[1];
                FlightCoordinator.AddFlightsFromFlightListToTempList(fly, FlightCoordinator.FlightsList, FlightCoordinator.TempFlightList2);
                Console.Clear();

                Console.WriteLine(FlightCoordinator.ShowDestinationFlights(fly, FlightCoordinator.FlightsList));
                FlightCoordinator.CopyAndClearList(FlightCoordinator.TempFlightList, FlightCoordinator.TempFlightList2);

                Console.WriteLine();
                Console.WriteLine("Select another destination by inputting the corresponding flight number or press '#' to exit");
            }
        }
        public static int ValidateInput(string input)
        {
            int output;
            if (input == "#")
            {
                Console.WriteLine("Program will exit now, good bye");
                Console.ReadKey();
                return 0;
            }
            while (!int.TryParse(input, out output) || int.Parse(input) > FlightCoordinator.TempFlightList.Count)
            {
                Console.WriteLine("Invalid input, please try again:");
                input = Console.ReadLine();
            }
            return output;
        }
    }
}
