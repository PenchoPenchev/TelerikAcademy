namespace _08.ShowShortBinaryRepresentation
{
    using System;
    using System.Text;

    class ShowShortBinaryRepresentation
    {
        /*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/
        
        static void Main()
        {
            Console.Write("Enter 16-bit signed number: ");
            short decNumber = short.Parse(Console.ReadLine());

            short tempDecNumber = decNumber;
            //sb will append the carry in every step
            StringBuilder sb = new StringBuilder();
            //temp will hold sb result before reverse
            string temp = string.Empty;

            while (tempDecNumber != 0)
            {
                sb.Append(tempDecNumber % 2);
                tempDecNumber = (short)(tempDecNumber / 2);
            }

            temp = sb.ToString().Replace("-","");
            sb.Clear();

            //reverse the sb string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                sb.Append(temp[i]);
            }

            string sbReversed = sb.ToString();
            sb.Clear();

            int divider = 16 - sbReversed.Length;

            do
            {
                sb.Append("0");
            } while (sb.Length % divider != 0);

            sb.Append(sbReversed);

            //If inputed number is negative then replace first bit from zero to one
            if (decNumber < 0)
            {
                sb.Replace("0", "1", 0, 1);
            }

            Console.WriteLine("{0}(10) = {1}(2)", decNumber, sb.ToString());
        }
    }
}
