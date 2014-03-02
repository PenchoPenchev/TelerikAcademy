namespace FindZerosAtTheEnd
{
    using System;
    using System.Numerics;

    class FindZerosAtTheEnd
    {
        static void Main()
        {
            /** Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
             * N = 10  N! = 3628800  2
             * N = 20  N! = 2432902008176640000  4
             * Does your program work for N = 50 000?
             * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!*/

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            BigInteger bigIntFactoriel = calcFactoriel(n);

            Console.WriteLine("{0}! = {1}", n, bigIntFactoriel);

            //First way=============================================================================
            Console.WriteLine("First way");

            string strFactoriel = bigIntFactoriel.ToString();
            int counter = 0;

            for (int i = strFactoriel.Length - 1; i > 0; i--)
            {
                if (strFactoriel[i] == '0')
                {
                    counter++;
                    if (strFactoriel[i-1] != '0')
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("{0} has {1} trailing zero(s).", bigIntFactoriel, counter);

            //Second way=============================================================================

            Console.WriteLine("Second way");

            int divider = 5;
            bool shouldContinue = true;
            byte newCounter = 0;

            while (shouldContinue)
            {
                if (bigIntFactoriel % divider != 0)
                {
                    shouldContinue = false;
                    break;
                }
                divider *= 5;
                newCounter++;
            }

            Console.WriteLine("{0} has {1} trailing zero(s).", bigIntFactoriel, newCounter);
        }

        public static BigInteger calcFactoriel(int number)
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
