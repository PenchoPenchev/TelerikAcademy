namespace _04.Hexadecimal2Decimal
{
    using System;
    using System.Text;

    class Hexadecimal2Decimal
    {
        /*Write a program to convert hexadecimal numbers to their decimal representation.*/
        
        static void Main()
        {
            Console.Write("Write a hexadecimal number: ");
            string hexNumber = Console.ReadLine().ToUpper();

            double decNumber = 0;

            for (int i = 0, exp = hexNumber.Length - 1; i < hexNumber.Length; i++, exp--)
            {
                switch (hexNumber[i].ToString())
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        decNumber += double.Parse(hexNumber[i].ToString()) * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "A":
                        decNumber += 10 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "B":
                        decNumber += 11 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "C":
                        decNumber += 12 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "D":
                        decNumber += 13 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "E":
                        decNumber += 14 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    case "F":
                        decNumber += 15 * Math.Pow(16, double.Parse(exp.ToString()));
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine("{0}(hex) = {1}(d)", hexNumber, decNumber);
        }
    }
}
