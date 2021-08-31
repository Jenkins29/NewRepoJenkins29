using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using FlightPlanner;
using Xunit;

namespace Collections.Exercise6.Test
{
    public class Exercise6Test
    {
        public const string Path = @"C:\Users\JL\NewRepoJenkins29\csharp-basics\exercises\Collections\FlightPlanner\flights.txt";
        
        [Fact]
        public void ReadFileInto2TempLists_ShouldTransferContentsOfFileIntoTempFlightListAndTempFlightList2()
        {
            // arrange
            var expected = new List<string>{"San Jose -> San Francisco",
                "San Jose -> Anchorage",
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu",
                "Anchorage -> New York",
                "Anchorage -> San Jose",
                "Honolulu -> New York",
                "Honolulu -> San Francisco",
                "Denver -> San Jose",
                "San Francisco -> New York",
                "San Francisco -> Honolulu",
                "San Francisco -> Denver"};

            var expected2 = new List<string>{"San Jose -> San Francisco",
                "San Jose -> Anchorage",
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu",
                "Anchorage -> New York",
                "Anchorage -> San Jose",
                "Honolulu -> New York",
                "Honolulu -> San Francisco",
                "Denver -> San Jose",
                "San Francisco -> New York",
                "San Francisco -> Honolulu",
                "San Francisco -> Denver"};

            // act
            List<string> testList3 = new List<string>();
            List<string> testList4 = new List<string>();
            FlightCoordinator.ReadFileInto2TempLists(Path, testList3, testList4);
            var actual = testList3;
            var actual2 = testList4;

            // Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected, actual2);
            Assert.Equal(expected2, actual);
        }

        [Fact]
        public void CopyAndClearList_ShouldCopyAndClearList()
        {
            //arrange
            var list1 = new List<string> {"flight1", "flight2", "flight3", "flight4", "flight5"};
            var list2 = new List<string> { "flight6", "flight7", "flight8", "flight9", "flight10" };

            list1.Clear();

            foreach (var flight in list2)
            {
                list1.Add(flight);
            }
            list2.Clear();

            var expected = list1;
            var expected2 = list2;

            //act
            var list3 = new List<string> { "flight1", "flight2", "flight3", "flight4", "flight5" };
            var list4 = new List<string> { "flight6", "flight7", "flight8", "flight9", "flight10" };
            FlightCoordinator.CopyAndClearList(list3, list4);

            var actual = list3;
            var actual2 = list4;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Empty(expected2);
            Assert.Empty(actual2);
        }

        [Fact]
        public void ShowStartMenu_ShouldReturnStringWithStartMenuOptions()
        {
            //arrange
            var expected = "What would you like to do?" + "\n" + "To display list of the cities press 1" + "\n" +
                           "To exit program press #";

            //act
            var actual = FlightCoordinator.ShowStartMenu();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DisplayStartingCities_InputListWithAllFlights_ShouldReturnListWithAllFlightsNumberedAsString()
        {
            //arrange
            var expected = "1 San Jose -> San Francisco" + "\n" +
                "2 San Jose -> Anchorage" + "\n" +
                "3 New York -> Anchorage" + "\n" +
                "4 New York -> San Jose" + "\n" +
                "5 New York -> San Francisco" + "\n" +
                "6 New York -> Honolulu" + "\n" +
                "7 Anchorage -> New York" + "\n" +
                "8 Anchorage -> San Jose" + "\n" +
                "9 Honolulu -> New York" + "\n" +
                "10 Honolulu -> San Francisco" + "\n" +
                "11 Denver -> San Jose" + "\n" +
                "12 San Francisco -> New York" + "\n" +
                "13 San Francisco -> Honolulu" + "\n" +
                "14 San Francisco -> Denver" + "\n";

            //act
            var list = new List<string>{"San Jose -> San Francisco",
                "San Jose -> Anchorage",
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu",
                "Anchorage -> New York",
                "Anchorage -> San Jose",
                "Honolulu -> New York",
                "Honolulu -> San Francisco",
                "Denver -> San Jose",
                "San Francisco -> New York",
                "San Francisco -> Honolulu",
                "San Francisco -> Denver"};

            var actual = FlightCoordinator.DisplayStartingCities(list);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowDestinationFlights_InputDenverAndListWithNumberedFlights_ShouldReturnFlightsFromDenverAsString()
        {
            //arrange
            var list = new List<string>{"San Jose -> San Francisco",
                "San Jose -> Anchorage",
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu",
                "Anchorage -> New York",
                "Anchorage -> San Jose",
                "Honolulu -> New York",
                "Honolulu -> San Francisco",
                "Denver -> San Jose",
                "San Francisco -> New York",
                "San Francisco -> Honolulu",
                "San Francisco -> Denver"};

            var input = "Denver";
            var expected = "1 Denver -> San Jose" +"\n";

            //act
            var actual = FlightCoordinator.ShowDestinationFlights(input, list);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddFlightsFromFlightListToTempList_InputNewYorkFlightListTempList_ShouldCreateListWithFlightsFromNewYork()
        {
            //arrange
            var list = new List<string>{"San Jose -> San Francisco",
                "San Jose -> Anchorage",
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu",
                "Anchorage -> New York",
                "Anchorage -> San Jose",
                "Honolulu -> New York",
                "Honolulu -> San Francisco",
                "Denver -> San Jose",
                "San Francisco -> New York",
                "San Francisco -> Honolulu",
                "San Francisco -> Denver"};
            
            var list2 = new List<string>();

            var expected = new List<string>
            {
                "New York -> Anchorage",
                "New York -> San Jose",
                "New York -> San Francisco",
                "New York -> Honolulu"
            };

            //act
            FlightCoordinator.AddFlightsFromFlightListToTempList("New York", list, list2);
            var actual = list2;

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
