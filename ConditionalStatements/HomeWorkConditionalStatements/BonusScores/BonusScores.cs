﻿namespace BonusScores
{
    using System;

    class BonusScores
    {
        static void Main(string[] args)
        {
            /*Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
             * If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
             * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, 
             * the program must report an error. 
             * Use a switch statement and at the end print the calculated new value in the console.*/

            byte counter = 0;
            byte digit = 0;

            while (counter < 1)
            {
                Console.Write("type a digit: ");
                bool isDigit = byte.TryParse(Console.ReadLine(), out digit);
                if (isDigit)
                {
                    counter++;
                }
            }

            switch (digit)
            {
                case 1:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 10, digit * 10);
                    break;
                case 2:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 10, digit * 10);
                    break;
                case 3:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 10, digit * 10);
                    break;
                case 4:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 100, digit * 100);
                    break;
                case 5:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 100, digit * 100);
                    break;
                case 6:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 100, digit * 100);
                    break;
                case 7:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 1000, digit * 1000);
                    break;
                case 8:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 1000, digit * 1000);
                    break;
                case 9:
                    Console.WriteLine("Scores {0}*{1}={2}", digit, 1000, digit * 1000);
                    break;
                default:
                    Console.WriteLine("Error! Not in the range [1-9]!");
                    break;
            }
        }
    }
}
