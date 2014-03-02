namespace _07.AnyBase2Any
{
    using System;
    using System.Text;

    class AnyBase2Any
    {
        /*Write a program to convert from any numeral system of given base s 
         * to any other numeral system of base d (2 ≤ s, d ≤  16).*/

        static void Main()
        {
            Console.Write("Type base numeral system >= 2 : ");
            int sBase = int.Parse(Console.ReadLine());

            Console.Write("Type wanted numeral system <= 16 : ");
            int dBase = int.Parse(Console.ReadLine());

            Console.Write("Type {0} base number = ", sBase);
            string sBaseNumber = Console.ReadLine().ToUpper();

            double doubleDecNumber = 0;

            if (sBase < 10)
            {
                for (int i = 0, exp = sBaseNumber.Length - 1; i < sBaseNumber.Length; i++, exp--)
                {
                    doubleDecNumber += double.Parse(sBaseNumber[i].ToString()) * Math.Pow(sBase, double.Parse(exp.ToString()));
                }
            }
            else
            {
                for (int i = 0, exp = sBaseNumber.Length - 1; i < sBaseNumber.Length; i++, exp--)
                {
                    switch (sBaseNumber[i].ToString())
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
                            doubleDecNumber += double.Parse(sBaseNumber[i].ToString()) * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "A":
                            doubleDecNumber += 10 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "B":
                            doubleDecNumber += 11 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "C":
                            doubleDecNumber += 12 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "D":
                            doubleDecNumber += 13 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "E":
                            doubleDecNumber += 14 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        case "F":
                            doubleDecNumber += 15 * Math.Pow(sBase, double.Parse(exp.ToString()));
                            break;
                        default:
                            break;
                    }

                }
            }

            int decNumber = (int)doubleDecNumber;
            //sb will append the carry in every step
            StringBuilder sb = new StringBuilder();
            //temp will hold sb result before reverse
            string temp = string.Empty;

            //Here inputed number is in decimal numeral system already
            //So this while cycle convert it from decimal to 'd' system
            while (decNumber != 0)
            {
                switch (decNumber % dBase)
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
                        sb.Append(decNumber % dBase);
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

                decNumber = decNumber / dBase;
            }

            temp = sb.ToString();
            sb.Clear();

            //reverse the sb string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                sb.Append(temp[i]);
            }

            Console.WriteLine("Result: {0}({2}) = {1}({3})", sBaseNumber, sb.ToString(), sBase, dBase);
        }
    }
}
