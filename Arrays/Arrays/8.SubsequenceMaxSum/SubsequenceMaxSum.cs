namespace _8.SubsequenceMaxSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SubsequenceMaxSum
    {
        static void Main()
        {
            /*Write  a  program,  which  finds  a  subsequence  of  numbers  with 
             * maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} 11*/

            int[] arr = { 12, 3, -6, 11, -8, -9, 6, 4, -8, 8 };

            List<int> tempList = new List<int>();
            List<int> finalList = new List<int>();

            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;

                for (int ii = i; ii < arr.Length; ii++)
                {
                    currentSum += arr[ii];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    tempList.Clear();
                    for (int ii = i; ii < arr.Length; ii++)
                    {
                        tempList.Add(arr[ii]);
                    }
                }
            }

            for (int i = 0; i < tempList.Count - 1; i++)
            {
                if (tempList[i] + tempList[i + 1] == 0)
                {
                    tempList.RemoveRange(i, 2);
                }
            }

            finalList = new List<int>(tempList);

            string finalResult = string.Join(" ", finalList.ToArray());
            Console.WriteLine("{0} = {1}", finalResult, maxSum);
        }
    }
}
