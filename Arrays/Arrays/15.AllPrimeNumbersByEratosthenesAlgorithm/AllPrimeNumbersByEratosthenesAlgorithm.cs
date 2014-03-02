namespace _15.AllPrimeNumbersByEratosthenesAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;

    class AllPrimeNumbersByEratosthenesAlgorithm
    {
        static void Main()
        {
            /*Write a program that finds all prime numbers in the range [1...10 000 000]. 
              * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();

            StringBuilder strBuilder = new StringBuilder();
            List<int> listNumbers = new List<int>();

            int inputUpperNumber = 100000;
            int cycles = inputUpperNumber;

            for (int i = 2; i < inputUpperNumber; i++)
            {
                listNumbers.Add(i);
            }

            int counter = 0;
            int maxDivisors = (int)Math.Sqrt(listNumbers.Count);

            for (int i = 0; i < maxDivisors; i++)
            {
                int divider = listNumbers[counter];

                for (int ii = 0; ii < listNumbers.Count; ii++)
                {
                    if (listNumbers[ii] % divider == 0 && listNumbers[ii] != divider)
                    {
                        listNumbers.Remove(listNumbers[ii]);
                    }
                }
                counter++;
                maxDivisors = (int)Math.Sqrt(listNumbers.Count);
            }

            string primeNumbers = string.Join(" ", listNumbers.ToArray());
            Console.WriteLine(primeNumbers);
            Console.WriteLine(listNumbers.Count);

            // Stop timing
            stopwatch.Stop();
            // Write result
            Console.WriteLine("Time elapsed: {0}",
                stopwatch.Elapsed);
        }
    }
}
