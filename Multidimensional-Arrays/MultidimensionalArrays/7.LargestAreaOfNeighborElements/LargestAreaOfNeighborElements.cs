namespace _7.LargestAreaOfNeighborElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class LargestAreaOfNeighborElements
    {
        //Class Position is needed to create a custom stack Stack<Position> stack = new Stack<Position>();
        //Better pseudo explanaition: Stack<matrix[row, col] stack = new Stack<matrix[row, col]>();
        //As the name hints this stack will hold the coords on every seen number, which replies to the conditions bellow
        class Position
        {
            private int x;
            private int y;

            public Position()
            {
                x = 0;
                y = 0;
            }

            public Position(int initializeX, int initializeY)
            {
                x = initializeX;
                y = initializeY;
            }

            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }

            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }

            }
        }

        static void Main()
        {
            /** Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.*/

            //Custom hardcoded matrix
            int[,] matrix = {
				{1, 3, 2, 2, 2, 4},
				{3, 3, 3, 2, 4, 4},
				{4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
			};

            //Bool matrix where by dafault all positions are False - not visited yet
            bool[,] matrixElemntIsVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            int memCounter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!matrixElemntIsVisited[row, col])
                    {
                        matrixElemntIsVisited[row, col] = true;
                        //There is an explanation at the top of this class - Position
                        Stack<Position> stack = new Stack<Position>();
                        stack.Push(new Position(row, col));
                        int counter = 0;

                        //This loop iterates while the stack is not empty
                        while (stack.Count > 0)
                        {
                            counter++;
                            //Every time I'm subtracting the latest pushed element as matrix coords - e.g. matrix[1, 3]
                            Position currentPosition = stack.Pop();

                            //I'm making four checks every time, because we have four possible directions - left, righ, up and down
                            if (currentPosition.Y - 1 >= 0)
                            {
                                Position nextPosition = new Position(currentPosition.X, currentPosition.Y - 1);

                                //IF nextPosition is not visited yet and the number is equal to currentPosition number
                                if (!matrixElemntIsVisited[nextPosition.X, nextPosition.Y] && 
                                    matrix[currentPosition.X, currentPosition.Y] == matrix[nextPosition.X, nextPosition.Y])
                                {
                                    matrixElemntIsVisited[nextPosition.X, nextPosition.Y] = true;
                                    stack.Push(nextPosition);
                                }
                            }
                            if (currentPosition.Y + 1 <= matrix.GetLength(1) - 1)
                            {
                                Position nextPosition = new Position(currentPosition.X, currentPosition.Y + 1);

                                if (!matrixElemntIsVisited[nextPosition.X, nextPosition.Y] &&
                                    matrix[currentPosition.X, currentPosition.Y] == matrix[nextPosition.X, nextPosition.Y])
                                {
                                    matrixElemntIsVisited[nextPosition.X, nextPosition.Y] = true;
                                    stack.Push(nextPosition);
                                }
                            }
                            if (currentPosition.X - 1 >= 0)
                            {
                                Position nextPosition = new Position(currentPosition.X - 1, currentPosition.Y);

                                if (!matrixElemntIsVisited[nextPosition.X, nextPosition.Y] &&
                                    matrix[currentPosition.X, currentPosition.Y] == matrix[nextPosition.X, nextPosition.Y])
                                {
                                    matrixElemntIsVisited[nextPosition.X, nextPosition.Y] = true;
                                    stack.Push(nextPosition);
                                }
                            }
                            if (currentPosition.X + 1 <= matrix.GetLength(0) - 1)
                            {
                                Position nextPosition = new Position(currentPosition.X + 1, currentPosition.Y);

                                if (!matrixElemntIsVisited[nextPosition.X, nextPosition.Y] &&
                                    matrix[currentPosition.X, currentPosition.Y] == matrix[nextPosition.X, nextPosition.Y])
                                {
                                    matrixElemntIsVisited[nextPosition.X, nextPosition.Y] = true;
                                    stack.Push(nextPosition);
                                }
                            }
                        }
                        if (counter > memCounter)
                        {
                            memCounter = counter;
                        }
                    }
                }
            }
            Console.WriteLine("The largest area is {0}", memCounter);
        }
    }
}
