namespace _06.Binary2Hexadecimal
{
    using System;
    using System.Text;

    class Binary2Hexadecimal
    {
        /*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

        static void Main()
        {
            Console.Write("Write a binary number: ");
            string binNumber = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            string hexNumber = string.Empty;

            //Add leading zeros if binary number '%' 4 is not null
            while (binNumber.Length % 4 != 0)
            {
                binNumber = "0" + binNumber;
            }

            for (int i = 0; i < binNumber.Length; i += 4)
            {
                StringBuilder temp = new StringBuilder();

                for (int ii = i; ii < i + 4; ii++)
                {
                    temp.Append(binNumber[ii]);    
                }
                
                switch (temp.ToString())
                {
                    case "0000":
                        sb.Append(0);
                        break;
                    case "0001":
                        sb.Append(1);
                        break;
                    case "0010":
                        sb.Append(2);
                        break;
                    case "0011":
                        sb.Append(3);
                        break;
                    case "0100":
                        sb.Append(4);
                        break;
                    case "0101":
                        sb.Append(5);
                        break;
                    case "0110":
                        sb.Append(6);
                        break;
                    case "0111":
                        sb.Append(7);
                        break;
                    case "1000":
                        sb.Append(8);
                        break;
                    case "1001":
                        sb.Append(9);
                        break;
                    case "1010":
                        sb.Append("A");
                        break;
                    case "1011":
                        sb.Append("B");
                        break;
                    case "1100":
                        sb.Append("C");
                        break;
                    case "1101":
                        sb.Append("D");
                        break;
                    case "1110":
                        sb.Append("E");
                        break;
                    case "1111":
                        sb.Append("F");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("{0}(b) = {1}(hex)", binNumber, sb.ToString());
        }
    }
}
