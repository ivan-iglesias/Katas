using System;
using Xunit;

namespace Katas.Tests
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(5, 5)]
        [InlineData(8, 21)]
        public void CanPrintFibonacci(int Number, int ExpectedResult)
        {
            // Act
            int result = Fibonacci.Of(Number);

            //Assert
            Assert.Equal(ExpectedResult, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(5, 5)]
        [InlineData(8, 21)]
        public void CanPrintRecursiveFibonacci(int Number, int ExpectedResult)
        {
            // Act
            int result = Fibonacci.Of(Number);

            //Assert
            Assert.Equal(ExpectedResult, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void CanThrowExceptionWhenNumberNotValid(int number)
        {
            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => Fibonacci.Of(number));

            //Assert
            Assert.Equal($"Entered number '{number}' does not meet rule, it should be between 0 and 100.", ex.Message);
        }
    }
}
