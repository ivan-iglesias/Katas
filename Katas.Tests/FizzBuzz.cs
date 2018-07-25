using Xunit;

namespace Katas.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void CanPrintFirst10Numbers()
        {
            // Act
            string result = FizzBuzz.Print(10);

            //Assert
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz,", result);
        }

        [Fact]
        public void CanPrintFirst35Numbers()
        {
            // Act
            string result = FizzBuzz.Print(35);

            //Assert
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz,", result);
        }
    }
}
