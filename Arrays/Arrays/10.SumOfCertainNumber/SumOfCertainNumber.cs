namespace _10.SumOfCertainNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SumOfCertainNumber
    {
        static void Main()
        {
            /*Write  a  program  to  find  a  sequence  of  neighbor  numbers  in  an  array, 
             * which has  a sum  of  certain number  S.  Example:  {4, 3, 1, 4, 2, 5, 8},
             * S=11  {4, 2, 5}.*/

            Console.Write("Find numbers with sum = ");
            short s = short.Parse(Console.ReadLine());

            short[] arr = { 4, 3, 1, 4, 2, 5, 8 };

            List<short> list = new List<short>();

            for (int i = 0; i < arr.Length; i++)
            {
                short tempSum = 0;

                for (int ii = i; ii < arr.Length; ii++)
                {
                    if (tempSum < s)
                    {
                        tempSum += arr[ii];
                        list.Add(arr[ii]);
                    }
                    else if (tempSum == s)
                    {
                        break;
                    }
                    else
                    {
                        list.Clear();
                        break;
                    }
                }
                if (tempSum == s)
                {
                    break;
                }
            }

            string result = string.Join(" ", list);
            Console.WriteLine(result);
        }
    }
}
