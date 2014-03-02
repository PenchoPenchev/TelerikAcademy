namespace _16.CheckSumOfSubsetIsS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class CheckSumOfSubsetIsS
    {
        static void Main()
        {
            /* * We are given an array of integers and a number S. 
             * Write a program to find if there exists a subset of the elements of the array that has a sum S. 
             * Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)*/

            //int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };

            //Console.Write("S = ");
            //int s = int.Parse(Console.ReadLine());

            //StringBuilder builder = new StringBuilder();
            //int[] arr2 = new int[arr.Length];

            //int sum = 0;
            //int position = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < s)
            //    {
            //        arr2[position] = arr[i];
            //        sum += arr[i];
            //    }
            //}

            //Console.WriteLine(builder.ToString());

            int[] numbers = new int[5];
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < 32; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += ((i >> j) & 1) * numbers[j];
                }
                if (sum == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter + " Subset Sums = 0"); 
        }
    }
}
