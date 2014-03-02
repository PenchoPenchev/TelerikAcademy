using System;

namespace _5.BiggerThanNeighbors
{
    public class BiggerThanNeighbors
    {
        /*Write a method that checks if the element at given position 
             * in given array of integers is bigger than its two neighbors (when such exist).*/

        public static int CheckIsBiggerThanNeighbors(int[] array, int position)
        {
            bool isBiggerThanLeft = true;
            bool isBiggerThanRight = true;
            
            if (position - 1 >= 0)
            {
                if (array[position - 1] >= array[position])
                {
                    isBiggerThanLeft = false;
                }
            }

            if (position + 1 < array.Length)
            {
                if (array[position] <= array[position + 1])
                {
                    isBiggerThanRight = false;
                }
            }

            if (isBiggerThanLeft && isBiggerThanRight)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void Main()
        {
            //Create hardcoded array for testing purposes
            int[] array = { 1, 2, 3, 4, 5, 6, 5, 6, 5, 2, 3, 2, 1 };

            Console.Write("Type a position between 0 and {0} = ", array.Length - 1);
            int position = int.Parse(Console.ReadLine());

            if (CheckIsBiggerThanNeighbors(array, position) != -1)
            {
                Console.WriteLine("Number at position {0} is Bigger than its neighbors", position);
            }
            else
            {
                Console.WriteLine("Number at position {0} is NOT bigger than its neighbors", position);
            }
            
        }
    }
}
