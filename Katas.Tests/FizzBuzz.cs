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
            string result = FizzBuzz.Of(Number);

            //Assert
            Assert.Equal(ExpectedResult, result);
        }

        [Theory]
        [InlineData(5, "1, 2, Fizz, 4, Buzz,")]
        [InlineData(10, "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz,")]
        [InlineData(25, "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz,")]
        public void CanPrintFizzBuzzWithFunc(int Number, string ExpectedResult)
        {
            // Arange
            Func<int, string>[] triggers = {
                (int i) => { return i % 3 == 0 ? "Fizz" : ""; },
                (int i) => { return i % 5 == 0 ? "Buzz" : ""; },
                (int i) => { return i % 3 != 0 && i % 5 != 0 ? $"{i}" : ""; }
            };

            // Act
            string result = FizzBuzz.Of(Number, triggers);

            //Assert
            Assert.Equal(ExpectedResult, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void CanThrowExceptionWhenNumberNotValid(int number)
        {
            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => FizzBuzz.Of(number));

            //Assert
            Assert.Equal($"Entered number '{number}' does not meet rule, it should be between 1 and 100.", ex.Message);
        }
    }
}
