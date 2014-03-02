namespace CalcCatalanNumbersByN
{
    using System;
    using System.Numerics;

    class CalcCatalanNumbersByN
    {
        static void Main()
        {
            /*Write a program to calculate the Nth Catalan number by given N.*/

            Console.WriteLine("Catalan numbers (2N)! / (N+1)!*N!.");
            Console.Write("N = ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine("(2*{0})! = {1}", n, calcFactoriel((byte)(2*n)));
            Console.WriteLine("({0}+1)! = {1}", n, calcFactoriel((byte)(n+1)));
            Console.WriteLine("{0}! = {1}", n, calcFactoriel(n));

            BigInteger result = calcFactoriel((byte)(2 * n)) / calcFactoriel((byte)(n + 1)) * calcFactoriel(n);
            Console.WriteLine("(2*{0})! / ({0}+1)! * {0}! = {1}", n, result);
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
