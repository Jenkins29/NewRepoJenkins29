using System;
using Exercise1;
using Xunit;

namespace ClassesAndObjects.Exercise1.Test
{
    public class Exercise1Test
    {
        [Fact]
        public void Product_InputLogitechPrice70pt00Units14_ShouldCreateNewProduct()
        {
            //arrange
            var expectedName = "Logitech";
            var expectedAmount = 14;
            var expectedPrice = 70.00;

            //act
            var actual = new Product("Logitech", 70.00, 14);
            var actualName = actual.Name;
            var actualAmount = actual.Amount;
            var actualPrice = actual.Price;

            //assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedPrice, actualPrice);
            Assert.Equal(expectedAmount, actualAmount);

        }

        [Fact]
        public void PrintProduct_NoInput_ShouldReturnIphonePrice999pt99EURAmount3()
        {
            //arrange
            var iPhone = new Product("iPhone", 999.99, 3);
            var expected = "iPhone, price 999,99 EUR, amount 3";

            //act
            var actual = iPhone.PrintProduct();

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]

        public void AddOrRemoveQuantity_Input15_ShouldReturn30()
        {
            //arrange
            var toy = new Product("Teddy Bear", 19.99, 15);
            var expected = 30;

            //act
            toy.AddOrRemoveQuantity(15);
            var actual = toy.Amount;

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]

        public void AddOrRemoveQuantity_InputMinus15_ShouldReturn0()
        {
            //arrange
            var toy2 = new Product("Teddy Bear", 19.99, 15);
            var expected = 0;

            //act
            toy2.AddOrRemoveQuantity(-15);
            var actual = toy2.Amount;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void ChangePrice_Input39pt99_ShouldReturn39pt99()
        {
            //arrange
            var ball = new Product("Ball", 29.99, 20);
            var expected = 39.99;

            //act
            ball.ChangePrice(39.99);
            var actual = ball.Price;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
