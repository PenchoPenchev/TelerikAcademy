namespace _02.Binary2Decimal
{
    using System;
    using System.Text;

    class Binary2Decimal
    {
        /*Write a program to convert binary numbers to their decimal representation.*/
        
        static void Main()
        {
            Console.Write("Write a binary number: ");
            string binNumber = Console.ReadLine();

            double decNumber = 0;

            for (int i = 0, exp = binNumber.Length - 1; i < binNumber.Length; i++, exp--)
            {
                decNumber += double.Parse(binNumber[i].ToString()) * Math.Pow(2, double.Parse(exp.ToString()));
            }

            Console.WriteLine("{0}b = {1}d", binNumber, decNumber);
        }
    }
}
