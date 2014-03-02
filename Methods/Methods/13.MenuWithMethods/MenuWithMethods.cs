namespace _13.MenuWithMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /*Write a program that can solve these tasks:
     * - Reverses the digits of a number
     * - Calculates the average of a sequence of integers
     * - Solves a linear equation a * x + b = 0
     * Create appropriate methods.
     * Provide a simple text-based menu for the user to choose which task to solve.
     * Validate the input data:
     * - The decimal number should be non-negative
     * - The sequence should not be empty
     * - a should not be equal to 0
     */

    class MenuWithMethods
    {
        public static void ReverseDigitsMethod(string number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }

            Console.WriteLine("Reversed number is {0}", sb.ToString());
        }
        
        static void Main()
        {
            Console.WriteLine("Menu".PadLeft(15));
            Console.WriteLine("1 - Reverse digits of a number\n2 - Calculates the average of a sequence");
            Console.WriteLine("3 - Solves a linear equation a * x + b = 0");
            Console.Write("Menu number? = ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    decimal decNumber;
                    Console.Write("Type a number: ");
                    bool isNonNegative = decimal.TryParse(Console.ReadLine(), out decNumber);
                    while (decNumber < 0)
                    {
                        Console.Write("Type non-negative number: ");
                        isNonNegative = decimal.TryParse(Console.ReadLine(), out decNumber);
                    }

                    string input = decNumber.ToString();

                    ReverseDigitsMethod(input);
                    break;
                case 2:
                    int counter = 0;
                    double sum = 0;

                    string input2 = "";

                    while (input2 == "")
                    {
                        Console.Write("Type a number: ");
                        input2 = Console.ReadLine();    
                    }

                    while (input2 != "=")
                    {
                        sum += double.Parse(input2);
                        counter++;
                        Console.Write("Type a number or press '=' to check the average result : ");
                        input2 = Console.ReadLine();
                    }

                    double average = sum / counter;
                    Console.WriteLine("The average of the sequence with sum {0} is {1}", sum, average);
                    break;
                case 3:
                    double a = 0;

                    while (a == 0)
                    {
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            Console.WriteLine("a should not be Zero");
                        }
                    }
                    Console.Write("c = ");
                    double c = double.Parse(Console.ReadLine());

                    double answer = -c / a;

                    Console.WriteLine("The answer of the equation {0} * x + {1} = 0 is {2}", a, c, answer);
                    break;
                default:
                    break;
            }
        }
    }
}
