namespace _4.BinarySearch
{
    using System;
    
    class BinarySearch
    {
        static void Main()
        {
            /*Write a program, that reads from the console an array of N integers and an integer K, 
             * sorts the array and using the method Array.BinSearch()
             * finds the largest number in the array which is ≤ K. */

            int[] integers = { 1, 3, 5, 2, 4, 7 };
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(integers);

            //integers = { 1, 2, 3, 4, 5, 7 };
            int index = Array.BinarySearch(integers, k);

            int kDiscounter = k;

            while (index < 0)
            {
                if (kDiscounter <= integers[0])
                {
                    break;
                }
                kDiscounter--;
                index = Array.BinarySearch(integers, kDiscounter);
            }

            if (index >= 0)
            {
                Console.WriteLine("The largest number in the array which is <= {0} is {1}", k, integers[index]);
            }
            else
            {
                Console.WriteLine("The element {0} is Not found", k);
            }
        }
    }
}
