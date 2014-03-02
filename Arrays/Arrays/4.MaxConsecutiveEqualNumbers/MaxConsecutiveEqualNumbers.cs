namespace _4.MaxConsecutiveEqualNumbers
{
    using System;
    using System.Text;

    class MaxConsecutiveEqualNumbers
    {
        static void Main()
        {
            /*Write a program, which finds the maximal sequence  of consecutive 
             * equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}. */

            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 2, 1, 4, 4, 4, 2 };

            int counter = 1;
            int memNumber = 0;
            int memCounter = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;

                    if (counter >= memCounter)
                    {
                        memCounter = counter;
                        memNumber = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("{0} was the most found number - {1} times in a row", memNumber, memCounter);
        }
    }
}
