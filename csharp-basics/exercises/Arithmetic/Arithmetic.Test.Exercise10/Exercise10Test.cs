using System;
using System.Runtime.InteropServices;
using CalculateArea;
using Xunit;
using Xunit.Sdk;

namespace Arithmetic.Test.Exercise10
{
    public class Exercise10Test
    {
        [Theory]
        [InlineData(25, 1963.495408)]
        [InlineData(35, 3848.451001)]
        [InlineData(1, 3.141593)]
        public void AreaOfCircle_InputRadius_ResultShouldBeArea(decimal radius, double expected)
        {
            // Act
            var actual = (Geometry.AreaOfCircle(radius)).ToString("0.000000");

            // Assert
            Assert.Equal(expected.ToString("0.000000"), actual);
        }

        [Fact]
        public void AreaOfCircle_NegativeInput_ResultShouldBeException()
        {
            //arrange
            var radius = -25;

            //act
            Action actual = () => Geometry.AreaOfCircle(radius);

            //assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Theory]
        [InlineData(20, 16, 160)]
        [InlineData(15, 3, 22.5)]
        [InlineData(80.67, 10.13, 408.59355)]
        public void AreaOfTriangle_InputBaseAndHeight_ResultShouldBeArea(decimal ground, decimal height, decimal expected)
        {
            // Act
            var actual = Geometry.AreaOfTriangle(ground, height);

            // Assert
            Assert.Equal((decimal)expected, (decimal)actual);
        }

        [Fact]
        public void AreaOfTriangle_NegativeHeightInput_ResultShouldBeException()
        {
            //arrange
            var height = -25;
            var ground = 15;

            //act
            Action actual = () => Geometry.AreaOfTriangle(ground, height);

            //assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void AreaOfTriangle_NegativeGroundInput_ResultShouldBeException()
        {
            //arrange
            var height = 25;
            var ground = -15;

            //act
            Action actual = () => Geometry.AreaOfTriangle(ground, height);

            //assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Theory]
        [InlineData(20, 16, 320)]
        [InlineData(15, 3, 45)]
        [InlineData(80.67, 10.13, 817.1871)]
        public void AreaOfRectangle_InputLengthAndWidth_ResultShouldBeArea(decimal length, decimal width, decimal expected)
        {
            // Act
            var actual = Geometry.AreaOfRectangle(length, width);
            // Assert
            Assert.Equal((decimal)expected, (decimal)actual);
        }

        [Fact]
        public void AreaOfRectangle_NegativeLengthInput_ResultShouldBeException()
        {
            //arrange
            var length = -35;
            var width = 15;

            //act
            Action actual = () => Geometry.AreaOfRectangle(length, width);

            //assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void AreaOfRectangle_NegativeWidthInput_ResultShouldBeException()
        {
            //arrange
            var length = 25;
            var width = -19;

            //act
            Action actual = () => Geometry.AreaOfRectangle(length, width);

            //assert
            Assert.Throws<ArgumentException>(actual);
        }
    }
}
