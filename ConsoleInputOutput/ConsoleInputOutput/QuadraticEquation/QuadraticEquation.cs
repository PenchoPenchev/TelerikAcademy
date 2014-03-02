namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real                  roots).*/

            double a = 0, b = 0, c = 0;
            double temp = 0;

            int counter = 0;

            bool parseSuccess;

            Console.WriteLine("Calculate ax^2 + bx + c = 0");

            while (counter < 3)
            {
                switch (counter)
                {
                    case 0:
                        Console.Write("a = ");
                        break;
                    case 1:
                        Console.Write("b = ");
                        break;
                    case 2:
                        Console.Write("c = ");
                        break;
                    default:
                        break;
                }
                parseSuccess = Double.TryParse(Console.ReadLine(), out temp);
                if (!parseSuccess)
                {
                    Console.WriteLine("Incorrect number. Please try again.");
                }
                else
                {
                    switch (counter)
                    {
                        case 0:
                            a = temp;
                            break;
                        case 1:
                            b = temp;
                            break;
                        case 2:
                            c = temp;
                            break;
                        default:
                            break;
                    }
                    counter++;
                }
            }

            Console.WriteLine("Equation {0}x^2 + {1}x + {2} = 0", a, b, c);

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D == 0)
            {
                Console.WriteLine("The equation has one double radical");
                Console.Write("X1,2 = ");
                double x12 = -b / 2 * a;
                Console.WriteLine(string.Format(string.Format("{0:+0.#####;-0.#####}", x12)));
            }
            else if (D < 0)
            {
                Console.WriteLine("The equation has NO real radicals");
            }
            else
            {
                Console.WriteLine("You have two radicals:");
                Console.Write("x1 = ");
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine(x1);
                Console.Write("x2 = ");
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine(x2);
            }
        }
    }
}
