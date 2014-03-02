namespace _18.RemainingSortedArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class RemainingSortedArray
    {
        static void Main()
        {
            /** Write a program that reads an array of integers and removes from it a minimal number of elements in such way 
             * that the remaining array is sorted in increasing order. Print the remaining sorted array. 
             * Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
             */
            //int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

            Console.Write("Type array length = ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            List<int> arrList = new List<int>();
            int latestMember = 0;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (latestMember <= arr[i] && arr[i] < arr[i + 1] && latestMember == 0)
                {
                    latestMember = arr[i];
                    arrList.Add(latestMember);
                }
                else if (latestMember > 0)
                {
                    //Check if current number arr[i] is the smallest number from the rest in the array and >= from the latest one added.
                    bool isNextNumber = true;
                    for (int ii = i + 1; ii < arr.Length - 1; ii++)
                    {
                        if ((arr[i] > arr[ii] || arr[i] < latestMember) && arr[ii] != 0)
                        {
                            isNextNumber = false; // current arr[i] number is not proper one
                            break;
                        }
                    }

                    if (isNextNumber)
                    {
                        latestMember = arr[i];
                        arrList.Add(latestMember);
                    }
                }
                // Check if the last number in the array is answering to the conditions to be added
                if (i == arr.Length - 2)
                {
                    if (latestMember <= arr[i + 1])
                    {
                        latestMember = arr[i + 1];
                        arrList.Add(latestMember);
                    }
                }
            }

            Console.WriteLine(string.Join(",", arrList));
        }
    }
}
