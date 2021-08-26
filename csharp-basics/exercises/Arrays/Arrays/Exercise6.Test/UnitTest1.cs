using System;
using System.Dynamic;
using Xunit;

namespace Exercise6.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreateArray_ShouldCreateAnArrayOfSize10()
        {
            // Arrange
            int [] array = new int[10];

            // Act
            var newArray = ArrayCreation.CreateArray();

            // Assert
            Assert.Equal(array, newArray);
        }

        [Fact]
        public void FillArrayWith10RandomsInRange1To100_ArrayShouldContain10RandomIntegersInRange1To100()
        {
            // Arrange
            int[] array = new int[10];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 100);
            }

            // Act
            var newArray = ArrayCreation.CreateArray();
            var finalArray = ArrayCreation.FillArrayWith10RandomsInRange1To100(newArray);

            // Assert
            for (int i = 0; i < finalArray.Length; i++)
            {
                Assert.InRange(i, 0, 100);
            }
        }

        [Fact]
        public void CopyArray_InputArray_ShouldCreateCopyOfInputArray()
        {
            // Arrange
            int[] array = new int[10];

            // Act
            var newArray = ArrayCreation.CopyArray(array);

            // Assert
            Assert.Equal(array, newArray);
        }

        [Fact]
        public void SetLastValueToMinus7_InputArray_ArrayLastValueShouldBeSetTo7()
        {
            // Arrange
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};

            // Act
            ArrayCreation.SetLastValueToMinus7(array);

            // Assert
            Assert.Equal(-7, array[9]);
        }

        [Fact]
        public void DisplayArrayContents_InputTwoArrays_ShouldReturnBothArrayContentsAsStrings()
        {
            // Arrange
            var array = ArrayCreation.CreateArray();
            var randomArr = ArrayCreation.FillArrayWith10RandomsInRange1To100(array);
            var randomArrCopy = ArrayCreation.CopyArray(randomArr);
            ArrayCreation.SetLastValueToMinus7(randomArr);

            var stringArr = string.Join(",", randomArr);
            var stringArr2 = string.Join(",", randomArrCopy);

            // Act
            var result = ArrayCreation.DisplayArrayContents(randomArr, randomArrCopy);

            // Assert
            Assert.Equal("Array 1: " + stringArr + "\n" + "Array 2: " + stringArr2, result);
        }
    }
}
