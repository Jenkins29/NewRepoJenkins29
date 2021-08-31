using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class FlightCoordinator
    {
        public const string Path = @"../FlightPlanner/Flights.txt";
        public static List<string> FlightsList = new List<string>();
        public static List<string> TempFlightList = new List<string>();
        public static List<string> TempFlightList2 = new List<string>();
        public static string DisplayStartingCities(List<string> list)
        {
            string result = string.Empty;
            int i = 1;
            foreach (var flight in list)
            {
                result += $"{i} {flight}"+"\n";
                i++;
            }
            return result;
        }
        public static string ShowDestinationFlights(string input, List<string> list)
        {
            int j = 1;
            string result = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                if (input != list[i].Replace(" -> ", "|").Split('|')[0]) continue;
                result += $"{j} {list[i]}" + "\n";
                j++;
            }
            return result;
        }
        public static void AddFlightsFromFlightListToTempList(string input, List<string> list, List<string> list2)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (input != list[i].Replace(" -> ", "|").Split('|')[0]) continue;
                list2.Add(list[i]);
            }
        }
        public static void CopyAndClearList(List<string> list1, List<string> list2)
        {
            list1.Clear();

            foreach (var flight in list2)
            {
                list1.Add(flight);
            }
            list2.Clear();
        }
        public static void ReadFileInto2TempLists(string filePath, List<string> list1, List<string> list2)
        {
            var readText = File.ReadAllLines(filePath);

            foreach (var s in readText)
            {
                list1.Add(s);
                list2.Add(s);
            }
        }
        public static string ShowStartMenu()
        {
            return "What would you like to do?" + "\n" + "To display list of the cities press 1" + "\n" +
                   "To exit program press #";
        }
    }
}
