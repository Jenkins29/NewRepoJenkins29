using System;
using Exercise1;
using Xunit;

namespace Arithmetic.Test.Exercise1
{
    public class Exercise1Test
    {
        [Fact]
        public void CheckIfNumberIs15_Input15And24_ShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberIs15(15, 24);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberIs15_Input16And24_ShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = CheckFor15.CheckIfNumberIs15(16, 24);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberSumIs15_Input7And8_ShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberSumIs15(7, 8);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberSumIs15_Input9And8_ShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = CheckFor15.CheckIfNumberSumIs15(9, 8);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberDifferenceIs15_Input31And16_ShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberDifferenceIs15(31, 16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNumberDifferenceIs15_Input32And19_ShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = CheckFor15.CheckIfNumberDifferenceIs15(32, 19);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
