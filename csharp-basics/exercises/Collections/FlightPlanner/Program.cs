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
        private const string Path = @"../FlightPlanner/Flights.txt";
        public static List<string> FlightsList = new List<string>();
        public static List<string> TempFlightList = new List<string>();
        public static List<string> TempFlightList2 = new List<string>();
        private static void Main(string[] args)
        {
            
            var readText = File.ReadAllLines(Path);
            bool wantToContinue = true;

            foreach (var s in readText)
            {
                int i = 0;
                FlightsList.Add(s);
                TempFlightList.Add(s);
                i++;
            }

            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            string[] userInputs = {"1", "#"};
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
                GetAndDisplayCities();
            }

            while (wantToContinue)
            {
                var userInput = Console.ReadLine();
                int flightNumber = ValidateInput(userInput);
                if (flightNumber == 0) break;

                var fly = TempFlightList[flightNumber - 1].Replace(" -> ", "|").Split('|')[1];

                Console.Clear();
                ShowDestinationFlights(fly);
                Console.WriteLine();
                Console.WriteLine("Select another destination by inputting the corresponding flight number or press '#' to exit");
            }
        }
        private static int ValidateInput(string input)
        {
            int output;
            if (input == "#")
            {
                Console.WriteLine("Program will exit now, good bye");
                Console.ReadKey();
                return 0;
            }
            while (!int.TryParse(input, out output) || int.Parse(input) > TempFlightList.Count)
            {
                Console.WriteLine("Invalid input, please try again:");
                input = Console.ReadLine();
            }

            return output;
        }
        private static void GetAndDisplayCities()
        {
            int i = 1;
            foreach (var flight in FlightsList)
            {
                Console.WriteLine(i + " " + flight);
                i++;
            }
        }
        public static void ShowDestinationFlights(string input)
        {
            int j = 1;

            for (int i = 0; i < FlightsList.Count; i++)
            {
                if (input == FlightsList[i].Replace(" -> ", "|").Split('|')[0])
                {
                   Console.WriteLine(j + " " + FlightsList[i]);
                   TempFlightList2.Add(FlightsList[i]);
                   j++;
                }
            }
            TempFlightList.Clear();

            foreach (var flight in TempFlightList2)
            {
                TempFlightList.Add(flight);
            }
            TempFlightList2.Clear();
        }
    }
}
