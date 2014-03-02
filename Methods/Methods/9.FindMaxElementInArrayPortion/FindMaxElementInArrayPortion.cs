namespace _9.FindMaxElementInArrayPortion
{
    using System;

    class FindMaxElementInArrayPortion
    {
        /*Write a method that return the maximal element in a portion of array of integers starting at given index. 
         * Using it write another method that sorts an array in ascending / descending order.*/

        public static int GetMaximalElementInPortion(int[] array, int startPosition)
        {
            int max = 0;
            int indexOfMaxElement = 0;

            for (int i = startPosition; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexOfMaxElement = i;
                }
            }

            return indexOfMaxElement;
            //Console.WriteLine("The maximal element in the range {0} - {1} is {2}", startPosition, array.Length - 1, max);
        }

        public static void DoAscOrder(int[] array, int startPosition)
        {
            int startIndex = GetMaximalElementInPortion(array, startPosition);
            int[] ascOrderedArray = new int[array.Length - startIndex];

            for (int i = startIndex, pos = 0; i < array.Length; i++, pos++)
            {
                ascOrderedArray[pos] = array[i];  
            }

            for (int i = 0; i < ascOrderedArray.Length; i++)
            {
                for (int ii = i + 1; ii < ascOrderedArray.Length; ii++)
                {
                    if (ascOrderedArray[ii] < ascOrderedArray[i])
                    {
                        int swapper = ascOrderedArray[i];
                        ascOrderedArray[i] = ascOrderedArray[ii];
                        ascOrderedArray[ii] = swapper;
                    }
                }
            }

            Console.Write("Ascending order - ");
            Console.Write(string.Join(" ", ascOrderedArray));
            Console.WriteLine();
        }

        public static void DoDescOrder(int[] array, int startPosition)
        {
            int startIndex = GetMaximalElementInPortion(array, startPosition);
            int[] descOrderedArray = new int[array.Length - startIndex];

            for (int i = startIndex, pos = 0; i < array.Length; i++, pos++)
            {
                descOrderedArray[pos] = array[i];
            }

            for (int i = 0; i < descOrderedArray.Length; i++)
            {
                for (int ii = i + 1; ii < descOrderedArray.Length; ii++)
                {
                    if (descOrderedArray[ii] > descOrderedArray[i])
                    {
                        int swapper = descOrderedArray[i];
                        descOrderedArray[i] = descOrderedArray[ii];
                        descOrderedArray[ii] = swapper;
                    }
                }
            }

            Console.Write("Descending order - ");
            Console.Write(string.Join(" ", descOrderedArray));
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Start array position = ");
            int startPosition = int.Parse(Console.ReadLine());

            int[] array = { 5, 1, 2, 3, 1, 5, 6, 10, 12, 7, 8, 10, 2};

            Console.WriteLine("Original array " + string.Join(" ", array));
            Console.WriteLine("Method GetMaximalElementInPortion returns = {0}", array[GetMaximalElementInPortion(array, startPosition)]);
            DoAscOrder(array, startPosition);
            DoDescOrder(array, startPosition);
        }
    }
}
