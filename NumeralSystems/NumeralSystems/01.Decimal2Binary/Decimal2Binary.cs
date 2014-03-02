namespace _01.Decimal2Binary
{
    using System;
    using System.Text;

    class Decimal2Binary
    {
        /*Write a program to convert decimal numbers to their binary representation.*/
        
        static void Main()
        {
            Console.Write("Write a decimal number: ");
            int decNumber = int.Parse(Console.ReadLine());

            int tempDecNumber = decNumber;
            //sb will append the carry in every step
            StringBuilder sb = new StringBuilder();
            //temp will hold sb result before reverse
            string temp = string.Empty;

            while (tempDecNumber != 0)
            {
                sb.Append(tempDecNumber % 2);
                tempDecNumber = tempDecNumber / 2;
            }

            temp = sb.ToString();
            sb.Clear();

            //reverse the sb string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                sb.Append(temp[i]);
            }

            Console.WriteLine("{0}d = {1}b", decNumber, sb.ToString());
        }
    }
}
