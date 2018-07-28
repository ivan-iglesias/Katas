using System;

namespace Katas
{
    public class FizzBuzz
    {

        /**
         * Fizz Buzz mediante condicionales.
         */
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

        private static bool IsFizz(int i) => i % 3 == 0;

        private static bool IsBuzz(int i) => i % 5 == 0;


        /**
         * Fizz Buzz usando delegados genericos tipo Func, los cuales se pasasan
         * mediante argumento para poder escalarlo con nuevas condiciones.
         */
        public static string Print(int Number, Func<int, string> [] Triggers)
        {
            string response = "";

            for (int i = 1; i <= Number; i++)
            {
                foreach (Func<int, string> Trigger in Triggers)
                {
                    response += Trigger(i);
                }
                response += ", ";
            }

            return response.TrimEnd();
        }

    }
}
