using System;
using Exercise2;
using Xunit;

namespace Arithmetic.Test.Exercise2
{
    public class Exercise2Test
    {
        [Fact]
        public void CheckNumber_Input15_ReturnsOddNumber()
        {
            // Arrange
            string expected = "Odd Number";

            // Act
            string actual = OddOrEven.CheckIfNumberIsOddOrEven(15);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckNumber_Input15_ReturnsEvenNumber()
        {
            // Arrange
            string expected = "Even Number";

            // Act
            string actual = OddOrEven.CheckIfNumberIsOddOrEven(16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldPrintBye()
        {
            // Arrange
            string expected = "bye!";

            // Act
            string actual = OddOrEven.PrintByeWhenExiting();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
