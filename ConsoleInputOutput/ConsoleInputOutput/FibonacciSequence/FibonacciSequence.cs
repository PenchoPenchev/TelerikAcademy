namespace FibonacciSequence
{
    using System;

    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            /*Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,                    233, 377, …*/
            int sequenceLen = 0;
            int counter = 0;

            Console.Write("Type a number: ");
            bool parseInput = Int32.TryParse(Console.ReadLine(), out sequenceLen);

            while (counter < 1)
            {
                if (!parseInput)
                {
                    Console.WriteLine("Incorrect number. Please try again.");
                    Console.Write("Type a number: ");
                    parseInput = Int32.TryParse(Console.ReadLine(), out sequenceLen);
                }
                else
                {
                    counter++;
                }
            }

            int firstNumber = 0;
            int secondNumber = 1;
            int nextNumber = 1;

            for (int i = 0; i < sequenceLen; i++)
            {
                if (i < 2)
                {
                    if (i == 0)
                    {
                        Console.Write(i + ", ");
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }
                else
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + ", ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
        }
    }
}
