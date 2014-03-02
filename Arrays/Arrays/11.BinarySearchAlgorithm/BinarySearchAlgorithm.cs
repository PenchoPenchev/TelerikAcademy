namespace _11.BinarySearchAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class BinarySearchAlgorithm
    {
        static void Main()
        {
            /*Write a program that finds the index of given element in a sorted array of integers by using 
             * the binary search algorithm (find it in Wikipedia).*/

            Console.Write("arrAscdendingay[N] N = ");
            int n = int.Parse(Console.ReadLine());

            int[] arrAscdending = new int[n];

            for (int i = 0; i < arrAscdending.Length; i++)
            {
                Console.Write("arrAscdending[{0}] = ", i);
                arrAscdending[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Search value = ");
            int value = int.Parse(Console.ReadLine());

            // Ascending sort
            for (int i = 0; i < arrAscdending.Length - 1; i++)
            {
                for (int ii = i + 1; ii < arrAscdending.Length; ii++)
                {
                    int temp;
                    if (arrAscdending[i] > arrAscdending[ii])
                    {
                        temp = arrAscdending[i];
                        arrAscdending[i] = arrAscdending[ii];
                        arrAscdending[ii] = temp;
                    }
                }
            }

            // BinarySearch method
            if (BinarySearch(arrAscdending, value) != -1)
            {
                Console.WriteLine("Searched value {0} was found at position {1}", value, BinarySearch(arrAscdending, value));
            }
            else
            {
                Console.WriteLine("Searched value {0} was not found", value);
            }
        }

        /*So what does binary search do – it defines start, end and middle points for the sorted array 
         * or range in which it will be performing a search. On each iteration, depending on how the value 
         * at the middle point compares to the value we are searching for, it redefines the start 
         * or end point and subsequently the middle point. This way the size of the array or range we are searching
         * in is effectively halved every iteration until we find what we search for or the exit conditions
         * are met before that (we have found nothing). The exit condition is start point > end point.*/
        public static int BinarySearch(int[] arr, int searchedValue)
        {
            int startPoint = 0, endPoint = arr.Length - 1, midPoint = 0;

            while (startPoint <= endPoint)
            {
                midPoint = (startPoint + endPoint) / 2;
                if (arr[midPoint] == searchedValue)
                {
                    return midPoint;
                }
                else if (arr[midPoint] < searchedValue)
                {
                    startPoint = midPoint + 1;
                    continue;
                }
                else if (arr[midPoint] > searchedValue)
                {
                    endPoint = midPoint - 1;
                }
            }

            // not found
            return -1;
        }
    }
}
