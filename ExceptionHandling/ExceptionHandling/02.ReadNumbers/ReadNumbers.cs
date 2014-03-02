using System;


class ReadNumbers
{
    /*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
        * If an invalid number or non-number text is entered, the method should throw an exception. 
        * Using this method write a program that enters 10 numbers:
		a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

    public static void ReadNumber(int start, int end)
    {
        try
        {
            Console.Write("Write a number = ");
            string value = Console.ReadLine();
            
            int number;

            bool isNumber = int.TryParse(value, out number);

            if (!isNumber)
            {
                throw new NotFiniteNumberException("Entered value is Not a number!");
            }

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("Entered number is out of given range!");
            }
        }
        catch (NotFiniteNumberException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Main()
    {
        int start = 0;
        int end = 0;

        bool isNumber = false;

        while (!isNumber)
        {
            Console.Write("Start = ");
            isNumber = int.TryParse(Console.ReadLine(), out start);
            if (!isNumber)
            {
                Console.WriteLine("Entered value is not a number! Try again.");    
            }
        }

        isNumber = false;

        while (!isNumber)
        {
            Console.Write("End = ");
            isNumber = int.TryParse(Console.ReadLine(), out end);
            if (!isNumber)
            {
                Console.WriteLine("Entered value is not a number! Try again.");
            }
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Row({0}): ", i);
            ReadNumber(start, end);
        }
    }
}
