using System;

namespace Katas
{
    public class FizzBuzz
    {

        /**
         * Fizz Buzz mediante condicionales.
         */
        public static string Of(int Number)
        {
            ThrowExceptionWhenNumberNotValid(Number);

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
        public static string Of(int Number, Func<int, string> [] Triggers)
        {
            ThrowExceptionWhenNumberNotValid(Number);

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


        /**
         * Genero una excepcion cuando se introduce un valor no valido.
         */
        private static void ThrowExceptionWhenNumberNotValid(int Number)
        {
            if (Number > 100 || Number < 1)
                throw new ArgumentException(
                    $"Entered number '{Number}' does not meet rule, it should be between 1 and 100."
                );
        }

    }
}
