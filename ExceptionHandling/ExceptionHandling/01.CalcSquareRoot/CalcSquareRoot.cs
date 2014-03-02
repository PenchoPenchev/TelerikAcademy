using System;

class CalcSquareRoot
{
    /*Write a program that reads an integer number and calculates and prints its square root. 
     * If the number is invalid or negative, print "Invalid number". 
     * In all cases finally print "Good bye". Use try-catch-finally.*/

    public static void CalcSqrt(double value)
    {
        if (value < 0)
        {
            throw new System.ArgumentOutOfRangeException("Invalid number!");
        }
        Console.WriteLine("Sqrt({0}) = {1}", value, Math.Sqrt(value));
    }

    static void Main()
    {
        try
        {
            Console.Write("Integer number : ");
            int value = int.Parse(Console.ReadLine());

            CalcSqrt(value);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
