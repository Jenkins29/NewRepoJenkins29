using System;
using Exercise5;
using Xunit;

namespace ClassesAndObjects.Exercise2.Test
{
    public class Exercise5Test
    {
        [Fact]
        public void Date_InputDay10Month10Year1976_ShouldCreateDate10Month10Year1976()
        {
            //arrange
            var expectedDay = 10;
            var expectedMonth = 10;
            var expectedYear = 1976;

            //act
            var actual = new Date(10, 10, 1976);
            var actualDay = actual.Day;
            var actualMonth = actual.Month;
            var actualYear = actual.Year;

            //assert
            Assert.Equal(expectedDay, actualDay);
            Assert.Equal(expectedMonth, actualMonth);
            Assert.Equal(expectedYear, actualYear);
        }

        [Fact]
        public void DisplayDate_NoInput_ShouldReturn15Slash12Slash1992()
        {
            //arrange
            var expected = "15/12/1992";

            //act
            var december = new Date(15, 12, 1992);
            var actual = december.DisplayDate();

            //assert
            Assert.Equal(expected,actual);
        }
    }
}
