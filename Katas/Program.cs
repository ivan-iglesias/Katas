using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            Fibonacci();
        }

        /**
         * Ejecuto la kata Fibonacci.
         */
        static void Fibonacci()
        {
            Console.WriteLine(Katas.Fibonacci.Of(10));
            Console.WriteLine(Katas.Fibonacci.RecursiveOf(10));
        }

        /**
        * Ejecuto la kata FizzBuzz.
        */
        static void FizzBuzz()
        {
            Console.WriteLine(Katas.FizzBuzz.Of(10));

            Func<int, string>[] triggers = {
                (int i) => { return i % 3 == 0 ? "Fizz" : ""; },
                (int i) => { return i % 5 == 0 ? "Buzz" : ""; },
                (int i) => { return i % 3 != 0 && i % 5 != 0 ? $"{i}" : ""; }
            };

            Console.WriteLine(Katas.FizzBuzz.Of(10, triggers));
        }
    }
}
