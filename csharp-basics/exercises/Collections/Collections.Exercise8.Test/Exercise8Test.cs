using System;
using Xunit;
using System.Collections.Generic;
using PhoneBook;

namespace Collections.Exercise8.Test
{
    public class Exercise8Test
    {
        [Fact]
        public void AddNewNumber_InputJanisLazdans29988774_ShouldReturnTrue()
        {
            //arrange
            var phoneEntry = new PhoneDirectory();
            var expected = true;

            //act
            phoneEntry.AddNewNumber("Janis Lazdans", "29988774");
            var actual = phoneEntry.PhoneEntries.ContainsKey("Janis Lazdans");
            var actual2 = phoneEntry.PhoneEntries.ContainsValue("29988774");

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual2);
        }

        [Fact]
        public void FindName_Input29988111_ShouldReturnStringWithKeyEddyBravo()
        {
            //arrange
            var phoneEntry2 = new PhoneDirectory();
            phoneEntry2.PhoneEntries.Add("Eddy Bravo", "29988111");
            var expected = "The name found under number 29988111 is: Eddy Bravo";

            //act
            var actual = phoneEntry2.FindName("29988111");

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void FindName_Input29988666_ShouldReturnNumberNotFoundError()
        {
            //arrange
            var phoneEntry3 = new PhoneDirectory();
            phoneEntry3.PhoneEntries.Add("Jon Smith", "29988555");
            var expected = "Number 29988666 was not found in your directory.";

            //act
            var actual = phoneEntry3.FindName("29988666");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumber_InputJaneSmith_ShouldReturnStringWithValue29988333()
        {
            //arrange
            var phoneEntry4 = new PhoneDirectory();
            phoneEntry4.PhoneEntries.Add("Jane Smith", "29988333");
            var expected = "Jane Smith's phone number is 29988333.";

            //act
            var actual = phoneEntry4.FindNumber("Jane Smith");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumber_InputJanisShmazdans_ShouldReturnNameNotFoundError()
        {
            //arrange
            var phoneEntry5 = new PhoneDirectory();
            phoneEntry5.PhoneEntries.Add("Janis Uzvards", "29988000");
            var expected = "No number with the name Janis Shmazdans was found.";

            //act
            var actual = phoneEntry5.FindNumber("Janis Shmazdans");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintContacts_ShouldPrintAllKeyValuePairsFromDirectoryAsString()
        {
            //arrange
            var phoneEntry6 = new PhoneDirectory();
            phoneEntry6.PhoneEntries.Add("a", "b");
            phoneEntry6.PhoneEntries.Add("c", "d");
            phoneEntry6.PhoneEntries.Add("e", "f");
            phoneEntry6.PhoneEntries.Add("g", "h");

            var expected = "Name: a, number: b " + "\n" + "Name: c, number: d " +
                           "\n" + "Name: e, number: f " + "\n" + "Name: g, number: h " + "\n";

            //act
            var actual = phoneEntry6.PrintContacts();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
