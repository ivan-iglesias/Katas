using System;

namespace Katas
{
    public class FizzBuzz
    {
        public static string Print(int Number)
        {
            string response = "";

            for (int i = 1; i <= Number; i++)
            {
                if (IsFizz(i)) response += "Fizz";
                if (IsBuzz(i)) response += "Buzz";
                if (!IsFizz(i) && !IsBuzz(i)) response += $"{i}";
                response += ", ";
            }

            return response.TrimEnd();
        }

        public static string Print(int Number, string[] Triggers)
        {
            string response = "";

            for (int i = 1; i <= Number; i++)
            {
                if (IsFizz(i)) response += "Fizz";
                if (IsBuzz(i)) response += "Buzz";
                if (!IsFizz(i) && !IsBuzz(i)) response += $"{i}";
                response += ", ";
            }

            return response.TrimEnd();
        }

        private static bool IsFizz(int i) => i % 3 == 0;

        private static bool IsBuzz(int i) => i % 5 == 0;
    }
}
