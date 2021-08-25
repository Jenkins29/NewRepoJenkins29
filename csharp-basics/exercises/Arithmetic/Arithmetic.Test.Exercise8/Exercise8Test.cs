using System;
using Exercise8;
using Xunit;

namespace Arithmetic.Test.Exercise8
{
    public class Exercise8Test
    {
        [Theory]
        [InlineData(7.50, 35, "Employee1", "Can't calculate Employee1's wage, because the base pay is below the minimum wage.")]
        [InlineData(8.20, 47, "Employee2", "Employee2's salary is 414,10")]
        [InlineData(10.00, 73, "Employee3", "Can't calculate Employee3's wage, because overtime hours exceed 20.")]
        [InlineData(12.00, 60, "Employee4", "Employee4's salary is 840,00")]
        [InlineData(9.47, 40, "Employee5", "Employee5's salary is 378,80")]
        [InlineData(8.40, 35, "Employee6", "Employee6's salary is 294,00")]
        public void CalculateWage_ShouldReturnStringWithWageOrError
            (double basePay, int hours, string name, string expected)
        {
            // Act
            var actual = WageCalculator.CalculateWage(basePay, hours, name);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
