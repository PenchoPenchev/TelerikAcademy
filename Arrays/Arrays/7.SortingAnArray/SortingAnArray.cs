namespace _7.SortingAnarrAscdendingay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SortingAnarrAscdendingay
    {
        static void Main(string[] args)
        {
            /*Sorting  an  arrAscdendingay  means  to  arrAscdendingange  its  elements  in  an  increasing  (or 
             * decreasing)  order.  Write  a  program,  which  sorts  an  arrAscdendingay  using  the 
             * algorithm "selection sort".*/

            Console.Write("arrAscdendingay[N] N = ");
            int n = int.Parse(Console.ReadLine());

            int[] arrAscdending = new int[n];
            int[] arrDescending = new int[n];

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < arrAscdending.Length; i++)
            {
                Console.Write("arrAscdending[{0}] = ", i);
                arrAscdending[i] = int.Parse(Console.ReadLine());
            }

            // Ascending sort
            for (int i = 0; i < arrAscdending.Length - 1; i++)
            {
                for (int ii = i + 1; ii < arrAscdending.Length; ii++)
                {
                    int temp;
                    if (arrAscdending[i] > arrAscdending[ii])
                    {
                        temp = arrAscdending[i];
                        arrAscdending[i] = arrAscdending[ii];
                        arrAscdending[ii] = temp;
                    }   
                }
            }

            for (int i = 0; i < arrAscdending.Length; i++)
            {
                builder.Append(arrAscdending[i] + " ");
            }

            Console.WriteLine("Ascending sort - {0}", builder.ToString());
            builder.Remove(0, builder.Length);

            // Descending sort
            for (int i = arrAscdending.Length - 1, j = 0; i >= 0; i--, j++)
            {
                arrDescending[j] = arrAscdending[i];
                builder.Append(arrDescending[j] + " ");
            }

            Console.WriteLine("Descending sort - {0}", builder.ToString());
        }
    }
}
