namespace _3.FindMaxSequenceOfNeighborElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class FindMaxSequenceOfNeighborElements
    {
        static void Main()
        {
            /*We are given a matrix of strings of size N x M. 
 		     * Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
 		     * Write a program that finds the longest sequence of equal strings in the matrix. */


            string[,] matrix = {
				{"ha", "fifi", "ho", "hi"},
				{"ani", "ha", "an", "ani"},
				{"xxx","fa","has","has"}
			};

            StringBuilder sb = new StringBuilder();
            StringBuilder sbMem = new StringBuilder();

            List<string> pastStrings = new List<string>();

            int currentRow = 0;
            int currentCol = 0;
            int memCounter = 0;

            //Get next unchecked string - the string and his coords 
            for (int row = currentRow; row < matrix.GetLength(0) - 1; row++)
            {
                bool hasThisStringAlready = false;
                for (int col = currentCol; col < matrix.GetLength(1) - 1; col++)
                {
                    foreach (var item in pastStrings)
                    {
                        if (item == matrix[row, col])
                        {
                            hasThisStringAlready = true;
                        }
                    }
                    if (!hasThisStringAlready)
                    {
                        pastStrings.Add(matrix[row, col]);
                    }
                }
            }

            foreach (var item in pastStrings)
            {
                sb.Append(item);

                int counter = 0;

                if (sb.ToString() != "")
                {
                    //Check neighbors in rows
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        counter = 0;

                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (sb.ToString() == matrix[row, col])
                            {
                                counter++;
                                if (counter > memCounter)
                                {
                                    memCounter = counter;
                                    sbMem.Clear();
                                    sbMem.Append(sb.ToString());
                                }
                            }
                            else
                            {
                                counter = 0;
                            }
                        }
                    }

                    //Check neighbors in columns
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        counter = 0;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            if (sb.ToString() == matrix[row, col])
                            {
                                counter++;
                                if (counter > memCounter)
                                {
                                    memCounter = counter;
                                    sbMem.Clear();
                                    sbMem.Append(sb.ToString());

                                }
                            }
                            else
                            {
                                counter = 0;
                            }
                        }
                    }

                    //Check neighbors in diagonal
                    int tempRow = 0;
                    int tempCol = 0;

                    for (tempCol = 0; tempCol < matrix.GetLength(1); tempCol++)
                    {
                        counter = 0;

                        for (tempRow = 0; tempRow < matrix.GetLength(0); tempRow++)
                        {
                            if (sb.ToString() == matrix[tempRow, tempCol])
                            {
                                counter++;
                                if (counter > memCounter)
                                {
                                    memCounter = counter;
                                    sbMem.Clear();
                                    sbMem.Append(sb.ToString());
                                }
                            }
                            else
                            {
                                counter = 0;
                            }
                            tempCol++;
                        }
                        tempCol = tempRow + 1;
                    }
                    sb.Clear();
                }
            }
            Console.WriteLine("The most found string is '{0}' - {1} times", sbMem.ToString(), memCounter);
        }
    }
}
