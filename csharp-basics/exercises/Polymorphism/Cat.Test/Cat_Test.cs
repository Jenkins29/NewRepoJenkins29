using System;
using Exercise6;
using Xunit;

namespace Cat.Test
{
    public class Cat_Test
    {
        [Fact]
        public void MakeSound_ShouldReturnMeow()
        {
            //arrange
            var cat = new Exercise6.Cat("cat", "Mincis", 2.7, "Latvija", "Mix");
            var expected = "meow";

            //act
            var actual = cat.MakeSound();

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ToString_ShouldReturnStringWithAllObjectInstanceVariables()
        {
            //arrange
            var cat = new Exercise6.Cat("cat", "Mincis", 2.7, "Latvija", "Mix");
            var expected = "Animal: cat, name: Mincis, weight: 2,7, region: Latvija, " +
                           $"breed: Mix, food eaten: 0";

            //act
            var actual = cat.ToString();

            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
