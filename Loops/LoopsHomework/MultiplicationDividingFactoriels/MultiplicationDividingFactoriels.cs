namespace MultiplicationDividingFactoriels
{
    using System;
    using System.Numerics;
    
    class MultiplicationDividingFactoriels
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

            Console.WriteLine("Calculates N!*K! / (K-N)! for given N and K (1<K<N).");
            Console.Write("N = ");
            byte n = byte.Parse(Console.ReadLine());

            Console.Write("K = ");
            byte k = byte.Parse(Console.ReadLine());

            Console.WriteLine("N! = {0}", calcFactoriel(n));
            Console.WriteLine("K! = {0}", calcFactoriel(k));
            Console.WriteLine("N! * K! = {0}", calcFactoriel(n) * calcFactoriel(k));

            byte nMinusK = (byte)(n - k);
            Console.WriteLine("(N-K)! = {0}", calcFactoriel(nMinusK));

            Console.WriteLine("Result {0}", (calcFactoriel(n) * calcFactoriel(k)) / calcFactoriel(nMinusK));

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
