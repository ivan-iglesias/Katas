using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz.Print(10));

            Func<int, string>[] triggers = {
                (int i) => { return i % 3 == 0 ? "Fizz" : ""; },
                (int i) => { return i % 5 == 0 ? "Buzz" : ""; },
                (int i) => { return i % 3 != 0 && i % 5 != 0 ? $"{i}" : ""; }
            };

            Console.WriteLine(FizzBuzz.Print(10, triggers));
        }
    }
}
