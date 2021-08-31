using System;
using Exercise6;
using Xunit;

namespace Zebra_Test
{
    public class ZebraTest
    {
        [Fact]
        public void MakeSound_ShouldReturnMeow()
        {
            //arrange
            var zebra = new Exercise6.Zebra("zebra", "Ross", 700.8, "Africa");
            var expected = "weirdZebraSounds";

            //act
            var actual = zebra.MakeSound();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_ShouldReturnStringWithAllObjectInstanceVariables()
        {
            //arrange
            var zebra = new Exercise6.Zebra("zebra", "Ross", 700.8, "Africa");
            var expected = $"Animal: zebra, name: Ross, weight: 700,8, region: Africa, food eaten: 0.";

            //act
            var actual = zebra.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_InputVegetable_ShouldSucceed()
        {
            //arrange
            var zebra = new Exercise6.Zebra("zebra", "Ross", 700.8, "Africa");
            Food veg = new Vegetable(100);
            var expected = 100;

            //act
            zebra.eat(veg);
            var actual = zebra._foodEaten;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_InputMeat_ShouldThrowException()
        {
            //arrange
            var zebra = new Exercise6.Zebra("zebra", "Ross", 700.8, "Africa");
            Food meat = new Meat(100);
            var expected = "A zebra doesn't eat meat";

            //act
            Action act = () => zebra.eat(meat);

            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expected, exception.Message);
        }
    }
}
