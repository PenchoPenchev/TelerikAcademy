namespace _6.MaxConsecutiveElementsSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MaxConsecutiveElementsSum
    {
        static void Main()
        {
            /*Write  a  program,  which  reads  from  the  console  two  integer  numbers  N
             * and  K  (K<N)  and  array  of  N  integers.  Find  those  K  consecutive 
             * elements in the array, which have maximal sum.*/

            Console.Write("Array[N] N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K < N, K = ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //asc sort array elements 
            Array.Sort(arr);

            StringBuilder builder = new StringBuilder();

            for (int i = arr.Length - k; i < arr.Length; i++)
            {
                sum += arr[i];
                if (i != arr.Length - 1)
                {
                    builder.Append(arr[i] + " + ");
                }
                else
                {
                    builder.Append(arr[i] + " = ");
                }
            }
            Console.WriteLine(builder.ToString() + sum);
        }
    }
}
