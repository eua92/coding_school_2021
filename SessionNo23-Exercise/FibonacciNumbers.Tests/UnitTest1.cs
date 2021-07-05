using System;
using Xunit;

namespace FibonacciNumbers.Tests
{
    public class UnitTest1
    {
        private Fibonacci CreateDefaultSUT()
        {
            var sut = new Fibonacci();
            return sut;
        }

        [Theory]
        [InlineData(9,34)]
        [InlineData(50, 12586269025)]
        public void CalculateFibonacciNumber_ValueBetweenOneAndNinetyIsGiven(long n, long expected)
        {
            //Arrange
            var sut = CreateDefaultSUT();

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacciNumber_ValueZeroIsGiven_ReturnsZero()
        {
            //Arrange
            var sut = CreateDefaultSUT();
            long n = 0;
            long expected = 0;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacciNumber_ValueOneIsGiven_ReturnsOne()
        {
            //Arrange
            var sut = CreateDefaultSUT();
            long n = 1;
            long expected = 1;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacciNumber_NegativeValueIsGiven_ThrowsArgumentException()
        {
            //Arrange
            var sut = CreateDefaultSUT();
            long n = -1;

            //Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var actual = sut.FibonacciSeries(n);
            });
        }

        [Fact]
        public void CalculateFibonacciNumber_ValueGreaterThanOrEqualToNinetyIsGiven_ThrowsArgumentException()
        {
            //Arrange
            var sut = CreateDefaultSUT();
            long n = 95;

            //Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var actual = sut.FibonacciSeries(n);
            });
        }
    }
}
