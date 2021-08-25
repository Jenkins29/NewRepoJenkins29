using System;
using GravityCalculator;
using Xunit;

namespace Arithmetic.Test.Exercise7
{
    public class Exercise7Test
    {
        [Fact]
        public void CalculatePositionAfter10SecFallTime_NoInput_ShouldReturnMinus490pt5()
        {
            // Arrange
            var expected = -490.5;

            // Act
            var actual = GravityCalculators.CalculatePositionAfter10SecFallTime();

            // Assert
            Assert.Equal(expected, actual);
            
        }
    }
}
