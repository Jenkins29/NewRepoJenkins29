using System;
using Xunit;
using Exercise6;

namespace Mouse.Test
{
    public class MouseTest
    {
        [Fact]
        public void MakeSound_ShouldReturnPeep()
        {
            //arrange
            var mouse = new Exercise6.Mouse("mouse", "Minnie", 0.6, "Latvija");
            var expected = "peep";

            //act
            var actual = mouse.MakeSound();

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Eat_InputVegetable_ShouldSucceed()
        {
            //arrange
            var mouse = new Exercise6.Mouse("mouse", "Minnie", 0.6, "Latvija");
            Food veg = new Vegetable(1);
            var expected = 1;

            //act
            mouse.eat(veg);
            var actual = mouse._foodEaten;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_InputMeat_ShouldThrowException()
        {
            //arrange
            var mouse = new Exercise6.Mouse("mouse", "Minnie", 0.6, "Latvija");
            Food meat = new Meat(1);
            var expected = "A mouse doesn't eat meat";

            //act
            Action act = () => mouse.eat(meat);

            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expected, exception.Message);
        }
    }
}
