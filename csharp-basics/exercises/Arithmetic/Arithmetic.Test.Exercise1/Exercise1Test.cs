using System;
using Exercise1;
using Xunit;

namespace Arithmetic.Test.Exercise1
{
    public class Exercise1Test
    {
        [Fact]
        public void Check_ShouldReturnTrueIfEitherNumIs15()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberIs15(15, 24);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnFalseIfNeitherNumIs15()
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = CheckFor15.CheckIfNumberIs15(16, 24);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnTrueIfSumIs15()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberSumIs15(7, 8);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnFalseIfSumIsNot15()
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = CheckFor15.CheckIfNumberSumIs15(9, 8);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnTrueIfDifferenceIs15()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = CheckFor15.CheckIfNumberDifferenceIs15(31, 16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnFalseIfDifferenceIsNot15()
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
