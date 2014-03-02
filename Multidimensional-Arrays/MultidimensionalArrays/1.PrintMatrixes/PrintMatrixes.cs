namespace _1.PrintMatrixes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class PrintMatrixes
    {
        static void Main()
        {
            Console.Write("Matrix size = ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine("A)");
            printTypeA(n);
            Console.WriteLine("B)");
            printTypeB(n);
            Console.WriteLine("C)");
            printTypeC(n);
            Console.WriteLine("D)");
            printTypeD(n);
        }

        public static void printTypeC(byte n)
        {
            int[,] matrix = new int[n, n];

            int counter = 1;
            int col = 0;
            int row = n - 1;
            int diagonalLen = 1;
            
            //There is two cases in two while cycles - from lefter border to the diagonal and after diagonal to the end
            //First case from row = n - 1 and col = 0 to row = 0 and col = n - 1
            while (row >= 0)
            {
                int row2 = row;
                col = 0;
                for (int i = 1; i <= diagonalLen; i++)
                {
                    matrix[row2, col] = counter;
                    col++;
                    row2++;
                    counter++;
                }
                diagonalLen++;
                row--;
            }

            diagonalLen = n - 1;
            col = 1;

            //Second case from row = 0 and col = 1 to row = n - 1 and col = n - 1
            while (col < n)
            {
                row = 0;
                int col2 = col;

                for (int i = 1; i <= diagonalLen; i++)
                {
                    matrix[row, col2] = counter;
                    col2++;
                    row++;
                    counter++;
                }

                col++;
                diagonalLen--;
            }

            StringBuilder builder = new StringBuilder();

            //Matrix print 
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    builder.Append(matrix[rows, cols].ToString().PadLeft(5, ' '));
                }
                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
        }

        public static void printTypeA(byte n)
        {
            int[,] matrix = new int[n, n];
            byte counter = 1;

            StringBuilder builder = new StringBuilder();

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    builder.Append(matrix[rows, cols].ToString().PadLeft(5, ' '));
                }
                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
        }

        public static void printTypeB(byte n)
        {
            int[,] matrix = new int[n, n];
            byte counter = 1;

            StringBuilder builder = new StringBuilder();

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }

            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    builder.Append(matrix[rows, cols].ToString().PadLeft(5, ' '));
                }
                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
        }

        public static void printTypeD(byte n)
        {
            int[,] matrix = new int[n, n];

            StringBuilder sbDirection = new StringBuilder();

            sbDirection.Append("down");
            sbyte row = 0;
            sbyte col = 0;
            byte snakeLenth = (byte)(n * n);

            for (int i = 1; i <= snakeLenth; i++)
            {
                if (sbDirection.ToString() == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    sbDirection.Replace(sbDirection.ToString(), "right");
                    row--;
                    col++;
                }
                else if (sbDirection.ToString() == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    sbDirection.Replace(sbDirection.ToString(), "up");
                    col--;
                    row--;
                }
                else if (sbDirection.ToString() == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    sbDirection.Replace(sbDirection.ToString(), "left");
                    row++;
                    col--;
                }
                else if (sbDirection.ToString() == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    sbDirection.Replace(sbDirection.ToString(), "down");
                    col++;
                    row++;
                }

                matrix[row, col] = i;

                switch (sbDirection.ToString())
                {
                    case "down":
                        row++;
                        break;
                    case "right":
                        col++;
                        break;
                    case "up":
                        row--;
                        break;
                    case "left":
                        col--;
                        break;
                    default:
                        break;
                }
            }

            sbDirection.Clear();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    sbDirection.Append(matrix[rows, cols].ToString().PadLeft(5, ' '));
                }
                sbDirection.AppendLine();
            }

            Console.WriteLine(sbDirection.ToString());
        }
    }
}
