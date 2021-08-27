using System;
using Exercise6;
using Xunit;

namespace Tiger.Test
{
    public class TigerTest
    {
        [Fact]
        public void MakeSound_ShouldReturnROAARRR()
        {
            //arrange
            var tiger = new Exercise6.Tiger("tiger", "Roger", 250, "South Asia");
            var expected = "ROAARRR!";

            //act
            var actual = tiger.MakeSound();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_ShouldReturnStringWithAllObjectInstanceVariables()
        {
            //arrange
            var tiger = new Exercise6.Tiger("tiger", "Roger", 250, "South Asia");
            var expected = $"Animal: tiger, name: Roger, weight: 250, region: South Asia, food eaten: 0.";

            //act
            var actual = tiger.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_InputMeat_ShouldSucceed()
        {
            //arrange
            var tiger = new Exercise6.Tiger("tiger", "Roger", 250, "South Asia");
            var meat = new Meat(20);
            var expected = 20;

            //act
            tiger.eat(meat);
            var actual = tiger._foodEaten;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_InputVegetable_ShouldThrowArgumentException()
        {
            //arrange
            var tiger = new Exercise6.Tiger("tiger", "Roger", 250, "South Asia");
            var vegetable = new Vegetable(20);
            var expected = "A tiger doesn't eat veggies, try meat";

            //act
            Action act = () => tiger.eat(vegetable);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expected, exception.Message);
        }
    }
}
