namespace InputIntDoubleStringVar
{
    using System;
    class InputIntDoubleStringVar
    {
        static void Main(string[] args)
        {
            /*Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or                 double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that                   variable as a console output. Use switch statement.*/

            Console.Write("Press 0 for int, 1 for double or 2 for string: ");
            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int intChoice = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(intChoice + 1);
                    break;
                case 2:
                    double doubleChoice = Double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleChoice + 1);
                    break;
                case 3:
                    string stringChoice = Console.ReadLine();
                    Console.WriteLine(stringChoice + "*");
                    break;
                default: Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
