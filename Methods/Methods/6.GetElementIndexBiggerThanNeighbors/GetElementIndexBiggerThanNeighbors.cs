namespace GetElementIndexBiggerThanNeighbors
{
    using System;
    using _5.BiggerThanNeighbors;

    class GetElementIndexBiggerThanNeighbors
    {
        /*Write a method that returns the index of the first element in array that is bigger than its neighbors, 
         * or -1, if there’s no such element.
         * Use the method from the previous exercise.*/

        public static int GetFirstElementBiggerThanNeighbors(int[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (BiggerThanNeighbors.CheckIsBiggerThanNeighbors(array, i) != -1)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static void Main()
        {
            //Create hardcoded array for testing purposes
            int[] array = { 1, 2, 3, 4, 5, 6, 5, 6, 5, 2, 3, 2, 1 };

            if (GetFirstElementBiggerThanNeighbors(array) != -1)
            {
                Console.WriteLine("The index of the first element in array that is bigger than its neighbors is {0}", GetFirstElementBiggerThanNeighbors(array));
            }
            else
            {
                Console.WriteLine("There is index in the array, which is bigger than its neighbors");
            }
        }
    }
}
