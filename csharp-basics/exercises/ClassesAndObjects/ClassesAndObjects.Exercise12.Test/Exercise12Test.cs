using System;
using Xunit;
using Account;

namespace ClassesAndObjects.Exercise12.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000000.00, 200.00, 999800.00)]
        [InlineData(10000.00, 2500.00, 7500.00)]
        [InlineData(55555.19, 30497.44, 25057.75)]
        [InlineData(4987.77, 5000.00, -12.23)]
        public void Withdrawal_Test(decimal money, decimal amountWithdrawn, decimal balance)
        {
            //arrange
            var expectedAccount = new Account.Account("Janis Bajanis", money);

            //act
            var result = expectedAccount.Withdrawal(amountWithdrawn);
            var actual = expectedAccount.Money;

            //assert
            Assert.Equal(balance, actual);

        }

        [Fact]
        public void SetMoney_Input15000pt56_ShouldSetMoneyTo15000pt56()
        {
            //arrange
            var newAccount = new Account.Account("Incognito", 14000.50m);
            var expected = 15000.56m;

            //act
            newAccount.Money = 15000.56m;
            var actual = newAccount.Money;

            //assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(1000000.00, 20000.67, 1020000.67)]
        [InlineData(10000.00, 33771.11, 43771.11)]
        [InlineData(55555.19, 30497.44, 86052.63)]
        [InlineData(-4987.77, 5000.00, 12.23)]
        public void Deposit_Test(decimal money, decimal amountDeposited, decimal balance)
        {
            //arrange
            var expectedAccount = new Account.Account("Thomas Anderson", money);

            //act
            expectedAccount.Deposit(amountDeposited);
            var actual = expectedAccount.Money;

            //assert
            Assert.Equal(balance, actual);
        }

        [Fact]
        public void SetName_InputNeo_ShouldSetNameToNeo()
        {
            //arrange
            var newAccount = new Account.Account("Thomas Anderson", 14000.50m);
            var expected = "Neo";

            //act
            newAccount.Name = "Neo";
            var actual = newAccount.Name;

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1000000.00, 1000000.00)]
        [InlineData(10000.00, 10000.00)]
        [InlineData(55555.19, 55555.19)]
        [InlineData(-4987.77, -4987.77)]
        public void Balance_Test(decimal money, decimal expected)
        {
            //arrange
            var morpheus = new Account.Account("Morpheus", money);

            //act
            var actual = morpheus.Balance();

            //
            Assert.Equal(money, expected);
        }

        [Theory]
        [InlineData("Morpheus", 9999999.99, "Morpheus: 9999999,99")]
        [InlineData("Trinity", 458489854.00, "Trinity: 458489854,00")]
        [InlineData("Agent Smith", 999999999999.99, "Agent Smith: 999999999999,99")]
        [InlineData("Cypher", 0.00, "Cypher: 0,00")]
        public void ToString_Test(string name, decimal money, string expected)
        {
            //arrange
            var matrix = new Account.Account(name, money);

            //act
            var actual = matrix.ToString();

            //
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Morpheus", 1000.00, 475.66, 524.34, "Naiobe", 750.00, 1225.66)]
        [InlineData("Trinity", 47000.37, 336.37, 46664.00, "Neo", 15000.00, 15336.37)]
        [InlineData("Tank", 16777.66, 475.66, 16302.00, "Dozer", 17547.77, 18023.43)]
        public void Transfer_Test(string name, decimal startingBalance, decimal amountTransferred, decimal expectedBalanceSender, 
            string recipient, decimal startingBalanceRecipient, decimal expectedBalanceRecipient)
        {
            //arrange
            var matrix = new Account.Account(name, startingBalance);
            var matrix2 = new Account.Account(recipient, startingBalanceRecipient);
            var expected = expectedBalanceSender;
            var expected2 = expectedBalanceRecipient;

            //act
            matrix.Transfer(matrix2, amountTransferred);
            var actual = matrix.Money;
            var actual2 = matrix2.Money;

            //
            Assert.Equal(actual, expected);
            Assert.Equal(actual2, expected2);
        }
    }
}
