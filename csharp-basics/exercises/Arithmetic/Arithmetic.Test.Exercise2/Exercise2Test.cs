using System;
using Exercise2;
using Xunit;

namespace Arithmetic.Test.Exercise2
{
    public class Exercise2Test
    {
        [Fact]
        public void CheckIfNumberIsOddOrEven_Input15_ShouldReturnOddNumber()
        {
            // Arrange
            string expected = "Odd Number";

            // Act
            string actual = OddOrEven.CheckIfNumberIsOddOrEven(15);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberIsOddOrEven_Input16_ShouldReturnEvenNumber()
        {
            // Arrange
            string expected = "Even Number";

            // Act
            string actual = OddOrEven.CheckIfNumberIsOddOrEven(16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintByeWhenExiting_NoInput_ShouldReturnBye()
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
