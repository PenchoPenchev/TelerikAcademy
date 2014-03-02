namespace _5.MaxConsecutiveIncreasingNumbers
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class MaxConsecutiveIncreasingNumbers
    {
        static void Main()
        {
            /*Write a program, which finds the maximal sequence  of  consecutively 
             * placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}. */

            int[] arr = { 3, 2, 3, 4, 2, 2, 4, 6, 7, 8, 7 };

            List<int> tempList = new List<int>();
            List<int> finalList = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    tempList.Add(arr[i]);
                    if (finalList.Count < tempList.Count)
                    {
                        finalList = new List<int>(tempList);
                    }
                }
                else
                {
                    tempList.Clear();
                }
            }

            int biggestNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggestNumber)
                {
                    biggestNumber = arr[i];
                }
            }

            if (finalList[finalList.Count - 1] < biggestNumber)
            {
                finalList.Add(biggestNumber);
            }

            string finalSequence = string.Join(" ", finalList.ToArray());
            Console.WriteLine("The most long sequence of incrementing numbers is {0}", finalSequence);
        }
    }
}
