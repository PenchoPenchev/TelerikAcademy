namespace _13.MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MergeSort
    {
        static void Main()
        {
            /** Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).*/

            int[] arr = { 3, 2, 1, 3, 4, 5, 5, 4, 3, 2 };

            //Console.Write("Array length = ");
            //int arrayLength = int.Parse(Console.ReadLine());

            //int[] arr = new int[arrayLength];
            StringBuilder bodyBuilder = new StringBuilder();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("array[{0}] = ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            // Merge sort
            MergeSortMethod(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                bodyBuilder.Append(arr[i] + " ");
            }

            Console.WriteLine(bodyBuilder.ToString());
        }

        public static void MergeSortMethod(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            int[] leftArray = new int[arr.Length / 2];
            int[] rightArray = new int[arr.Length - leftArray.Length];
            int rightArrayIndex = 0;

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = arr[i];
            }
            for (int i = leftArray.Length; i < arr.Length; i++)
            {
                rightArray[rightArrayIndex] = arr[i];
                rightArrayIndex++;
            }

            /** Recursive - we aim to create many arrays with one number. 
             * e.g. leftArray.length = 1 - leftArray[0] = 2
             * rightArray,length = 1 - rightArray[0] = 1*/
            MergeSortMethod(leftArray);
            MergeSortMethod(rightArray);

            // Compare and merge the values from the two arrays in one sorted array with two values
            int[] mergedArrays = DoSort(leftArray, rightArray);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = mergedArrays[i];
            }
        }

        private static int[] DoSort(int[] leftArr, int[] rightArr)
        {
            int[] mergedArr = new int[leftArr.Length + rightArr.Length];
            int mergedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < leftArr.Length || rightIndex < rightArr.Length)
            {
                if (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
                {
                    if (leftArr[leftIndex] > rightArr[rightIndex])
                    {
                        mergedArr[mergedIndex] = rightArr[rightIndex];
                        rightIndex++;
                    }
                    else
                    {
                        mergedArr[mergedIndex] = leftArr[leftIndex];
                        leftIndex++;
                    }
                }
                else if (leftIndex >= leftArr.Length && rightIndex < rightArr.Length)
                {
                    mergedArr[mergedIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
                else if (leftIndex < leftArr.Length && rightIndex >= rightArr.Length)
                {
                    mergedArr[mergedIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                mergedIndex++;
            }
          
            return mergedArr;
        }
    }
}
