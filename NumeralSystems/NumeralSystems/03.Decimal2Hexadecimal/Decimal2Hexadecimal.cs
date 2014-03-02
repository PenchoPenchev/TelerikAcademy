namespace _03.Decimal2Hexadecimal
{
    using System;
    using System.Text;

    class Decimal2Hexadecimal
    {
        /*Write a program to convert decimal numbers to their hexadecimal representation.*/

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
                switch (tempDecNumber % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        sb.Append(tempDecNumber % 16);
                        break;
                    case 10:
                        sb.Append("A");
                        break;
                    case 11:
                        sb.Append("B");
                        break;
                    case 12:
                        sb.Append("C");
                        break;
                    case 13:
                        sb.Append("D");
                        break;
                    case 14:
                        sb.Append("E");
                        break;
                    case 15:
                        sb.Append("F");
                        break;
                    default:
                        break;
                }
                
                tempDecNumber = tempDecNumber / 16;
            }

            temp = sb.ToString();
            sb.Clear();

            //reverse the sb string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                sb.Append(temp[i]);
            }

            Console.WriteLine("{0}(10) = {1}(16)", decNumber, sb.ToString());
        }
    }
}
