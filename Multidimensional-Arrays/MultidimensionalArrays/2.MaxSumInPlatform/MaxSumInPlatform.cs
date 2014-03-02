namespace _2.MaxSumInPlatform
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MaxSumInPlatform
    {
        /*Write a program that reads a rectangular matrix of size N x M 
         * and finds in it the square 3 x 3 that has maximal sum of its elements*/

        static void Main()
        {
            int[,] rectangular = 
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, -9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 },
                { 5, 12, -6, 0, 1, 6 },
                { 1, 0, 3, 9, 6, 12 }
            };

            int maxSum = 0;

            for (int row = 0; row < rectangular.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < rectangular.GetLength(1) - 1; col++)
                {
                    int tempSum = rectangular[row, col] + rectangular[row, col + 1] + rectangular[row + 1, col] + rectangular[row + 1, col + 1];

                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
