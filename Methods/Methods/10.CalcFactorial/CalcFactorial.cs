namespace _10.CalcFactorial
{
    using System;
    using System.Numerics;

    class CalcFactorial
    {
        /*Write a program to calculate n! for each n in the range [1..100]. 
         * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

        public static void CalcFactorialMethod(int nFac)
        {
            BigInteger first = 1;
            BigInteger result = 1;

            for (int i = 1; i <= nFac; i++)
            {
                result = first * i;
                first = result;
            }
            Console.WriteLine("{0}! = {1}", nFac, result);
        }

        static void Main()
        {
            Console.Write("Print factorial from 1 to ");
            int n = int.Parse(Console.ReadLine());
            
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                CalcFactorialMethod(array[i]);
            }
        }
    }
}
