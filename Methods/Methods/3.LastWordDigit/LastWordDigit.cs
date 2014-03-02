namespace _3.LastWordDigit
{
    using System;

    class LastWordDigit
    {
        public static void PrintDigitName(int digit)
        {
            switch (digit)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                default:
                    Console.Write("Invalid digit");
                    break;
            }
        }
        
        static void Main()
        {
            Console.Write("Type a number: ");
            string input = Console.ReadLine();

            int lastDigit = int.Parse(input[input.Length - 1].ToString());
            Console.Write("{0} --> ", input);
            PrintDigitName(lastDigit);
            Console.WriteLine();
        }
    }
}
