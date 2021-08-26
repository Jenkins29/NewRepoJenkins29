using System;
using WordCount;
using Xunit;

namespace Collections.Exercise5.Test
{
    public class Exercise5Test
    {
        public string filePath = @"../WordCount/lear.txt";

        [Fact]
        public void LineCounter_InputFilePath_ShouldReturnCount6()
        {
            // Arrange
            var expected = 6;

            // Act
            var actual = FileAnalyzer.LineCounter(filePath);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCounter_InputFilePath_ShouldReturnCount47()
        {
            // Arrange
            var expected = 47;

            // Act
            var actual = FileAnalyzer.WordCounter(filePath);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CharCounter_InputFilePath_ShouldReturnCount248()
        {
            // Arrange
            var expected = 248;

            // Act
            var actual = FileAnalyzer.CharCounter(filePath);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
