namespace _20.AllVariationsOfKElements
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    class AllVariationsOfKElements
    {
        static void Main()
        {
            /*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
             * Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            //This list will hold K number of '1'
            List<int> oList = new List<int>();

            for (int i = 0; i < k; i++)
            {
                oList.Add(1);
            }

            int pos = k - 1;
            bool shouldIterate = true;

            while (shouldIterate)
            {
                int internalPos = pos;

                if (oList[internalPos] < n && internalPos < k - 2)
                {
                    while (oList[internalPos] < n && internalPos < k - 2)
                    {
                        oList[internalPos]++;
                        Console.WriteLine(string.Join(",", oList));
                        internalPos++;
                        pos++;
                    }
                }
                else
                {   
                    while (oList[internalPos] < n)
                    {   
                        //Incrementing from left to right by one step by step positions till k - 1 
                        if (internalPos != oList.Count - 1)
                        {
                            oList[internalPos]++;
                        }

                        //Incrementing only the rightest numbers from 1 to n
                        for (int iii = 1; iii <= n; iii++)
                        {
                            oList[k - 1] = iii;
                            Console.WriteLine(string.Join(",", oList));
                        }
                    }

                    //Reset all values from current position to k - 1 to 1
                    if (pos > 0)
                    {
                        for (int iii = pos; iii < k; iii++)
                        {
                            oList[iii] = 1;
                        }
                    }

                    if (pos > 0)
                    {
                        pos--;
                    }
                    else if (pos <= 0)
                    {
                        shouldIterate = false;
                    }
                }
            }
        }
    }
}
