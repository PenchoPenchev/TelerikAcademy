namespace Snake
{
    using System;
    using System.Text;

    class Snake
    {
        static void Main(string[] args)
        {
            /* * Write a program that reads a positive integer number N (N < 20) from console and outputs in the console 
             * the numbers 1 ... N numbers arranged as a spiral.*/
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            StringBuilder direction = new StringBuilder();

            int row = 0;
            int col = 0;
            direction.Append("right");
            int snakeLength = n * n;

            for (int i = 1; i <= snakeLength; i++)
            {
                if (direction.ToString() == "right" && (col > n - 1 || matrix[row,col] != 0))
                {
                    direction.Replace(direction.ToString(), "down");
                    row++;
                    col--;
                }
                else if (direction.ToString() == "down" && (row > n - 1 || matrix[row,col] != 0))
                {
                    direction.Replace(direction.ToString(), "left");
                    row--;
                    col--;
                }
                else if (direction.ToString() == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction.Replace(direction.ToString(), "up");
                    row--;
                    col++;
                }
                else if (direction.ToString() == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction.Replace(direction.ToString(), "right");
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                switch (direction.ToString())
                {
                    case "right":
                        col++;
                        break;
                    case "down":
                        row++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "up":
                        row--;
                        break;
                    default:
                        break;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,5}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
