namespace CalculatesNnXsequence
{
    using System;
    using System.Numerics;

    class CalculatesNnXsequence
    {
        static void Main(string[] args)
        {
            /*Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/X^N*/

            Console.WriteLine("Calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N.");
            Console.Write("N = ");
            byte n = byte.Parse(Console.ReadLine());

            Console.Write("X = ");
            byte x = byte.Parse(Console.ReadLine());

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += (double)calcFactoriel((byte)i) / Math.Pow(x,i);
                Console.Write("{0}/{1}^{2}", calcFactoriel((byte)i),x,i);
                if (i != n)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(" = {0}", sum);
                    Console.WriteLine();
                }
            }
        }

        public static BigInteger calcFactoriel(byte number)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }
    }
}
