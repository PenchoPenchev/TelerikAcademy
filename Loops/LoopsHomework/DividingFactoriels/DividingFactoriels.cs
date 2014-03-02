namespace DividingFactoriels
{
    using System;
    using System.Numerics;

    class DividingFactoriels
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates N!/K! for given N and K (1<K<N).*/

            Console.WriteLine("Calculates N!/K! for given N and K (1<K<N).");
            Console.Write("N = ");
            byte n = byte.Parse(Console.ReadLine());

            Console.Write("K = ");
            byte k = byte.Parse(Console.ReadLine());

            Console.WriteLine("N! = {0}", calcFactoriel(n));
            Console.WriteLine("K! = {0}", calcFactoriel(k));
            Console.WriteLine("N! / K! = {0}", calcFactoriel(n) / calcFactoriel(k));

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
