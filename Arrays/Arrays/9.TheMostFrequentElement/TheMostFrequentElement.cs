namespace _9.TheMostFrequentElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TheMostFrequentElement
    {
        static void Main()
        {
            /*Write a program, which finds the most frequently occurring element in 
             * an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).*/

            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int MostFrequentElementCounter = 0;
            int MostFrequentElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int tempMostFrequentElementCounter = 0;
                int tempMostFrequentElement = 0;

                for (int ii = i; ii < arr.Length; ii++)
                {
                    if (tempMostFrequentElement == 0)
                    {
                        tempMostFrequentElement = arr[ii];
                        tempMostFrequentElementCounter++;
                    }
                    else if (arr[ii] == tempMostFrequentElement)
                    {
                        tempMostFrequentElementCounter++;
                    }
                }

                if (tempMostFrequentElementCounter > MostFrequentElementCounter)
                {
                    MostFrequentElement = tempMostFrequentElement;
                    MostFrequentElementCounter = tempMostFrequentElementCounter;
                }
            }

            Console.WriteLine("{0} ({1} times)", MostFrequentElement, MostFrequentElementCounter);
        }
    }
}
