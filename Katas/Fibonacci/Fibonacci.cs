using System;

namespace Katas
{
    public class Fibonacci
    {
        /**
         * Calculo la sucesion de Fibonacci del numero dado.
         */
        public static int Of(int Number)
        {
            ThrowExceptionWhenNumberNotValid(Number);

            if (Number == 0 || Number == 1) return Number;

            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= Number; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        /**
         * Calculo la sucesion de Fibonacci usando recursividad.
         */
        public static int RecursiveOf(int Number)
        {
            ThrowExceptionWhenNumberNotValid(Number);

            if (Number == 0 || Number == 1) return Number;

            return RecursiveOf(Number - 1) + RecursiveOf(Number - 2);
        }

        /**
         * Genero una excepcion cuando se introduce un valor no valido.
         */
        private static void ThrowExceptionWhenNumberNotValid(int Number)
        {
            if (Number > 100 || Number < 0)
                throw new ArgumentException(
                    $"Entered number '{Number}' does not meet rule, it should be between 0 and 100."
                );
        }

    }
}
