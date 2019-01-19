using System;
using Xunit;

namespace Katas.Tests
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(5, "1, 2, Fizz, 4, Buzz,")]
        [InlineData(10, "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz,")]
        [InlineData(25, "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz,")]
        public void CanPrintFizzBuzz(int Number, string ExpectedResult)
        {
            // Act
            string result = FizzBuzz.Print(Number);

            //Assert
            Assert.Equal(ExpectedResult, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void CanThrowExceptionWhenNumberNotValid(int number)
        {
            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => FizzBuzz.Print(number));

            //Assert
            Assert.Equal($"Entered number '{number}' does not meet rule, it should be between 1 and 100.", ex.Message);
        }
    }
}
