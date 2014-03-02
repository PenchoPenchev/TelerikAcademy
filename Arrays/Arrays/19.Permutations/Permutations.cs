namespace _19.Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Permutations
    {
        static void Main()
        {
            /** Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
             * Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}  
             The number of permutations of n distinct objects is "n factorial" usually written as "n!", 
             * which means the product of all positive integers less than or equal to n.*/

            Console.Write("Type a number N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<int> PermutationList = new List<int>();
            BigInteger nFac = 1; //Holds N!
            BigInteger nFacMinusOne = 1; // Holds (N - 1)! - I need this number for the nested loop below

            //As N permutations are equal to N! - here I calc N!
            for (int i = 1; i < n; i++)
            {
                nFac += nFac * i;
                if (i < n - 1)
                {
                    nFacMinusOne += nFacMinusOne * i;
                }
            }

            //Generating first permutation
            for (int i = 1; i <= n; i++)
            {
                PermutationList.Add(i);
            }

            int row = 1;

            //
            for (int i = 0; i < n; i++)
            {
                int position = 1;
                bool shouldBeIncreased = true;

                //If i > 0 means that we have N! / N permutations for all elements >= PermutationList[1]
                if (i > 0)
                {
                    //So next time the first and the second element will swap their positions until latest element come first
                    int swap = PermutationList[1];
                    PermutationList[1] = PermutationList[0];
                    PermutationList[0] = swap;
                }

                //Generates all permutations of N - 1
                for (int ii = 0; ii < nFacMinusOne; ii++)
                {
                    int swap = PermutationList[position + 1];
                    PermutationList[position + 1] = PermutationList[position];
                    PermutationList[position] = swap;
                    //Print current row
                    Console.Write(row + " : ");
                    row++;
                    //Print permutation
                    Console.WriteLine(string.Join(",", PermutationList));

                    //Forward in position or backward depends the Permutation numbers length
                    if (shouldBeIncreased && position < PermutationList.Count - 2)
                    {
                        position++;
                    }
                    else
                    {
                        if (position > 1)
                        {
                            shouldBeIncreased = false;
                            position--;
                        }
                        else
                        {
                            shouldBeIncreased = true;
                        }
                    }
                }
            }
        }
    }
}
