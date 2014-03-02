namespace CheckSubset
{
    using System;
    class CheckSubset
    {
        static void Main(string[] args)
        {
            /*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
            * Example: 3, -2, 1, 1, 8  1+1-2=0.*/

            int[] numbers = { 3, -2, 1, 1, 8};
            int[] subsetNumbers = new int[numbers.Length];
            int sum = 0;
            bool noZeroSubset = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    subsetNumbers[j] = numbers[j];
                    if (sum == 0)
                    {
                        break;
                    }
                }
                if (sum != 0)
                {
                    Array.Clear(subsetNumbers, 0, 5);
                    sum = 0;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < subsetNumbers.Length; i++)
            {
                if (subsetNumbers[i] != 0)
                {
                    Console.Write(subsetNumbers[i] + " ");
                    noZeroSubset = false;
                }
                if (i == subsetNumbers.Length - 1 && noZeroSubset == false)
                {
                    Console.Write("= 0");
                }
            }

            if (noZeroSubset)
            {
                Console.WriteLine("There is no zero subset.");
            }
            Console.WriteLine();
        }
    }
}
