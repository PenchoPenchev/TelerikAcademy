namespace _7.ReversDigits
{
    using System;
    using System.Text;

    class ReverseDigits
    {
        /*Write a method that reverses the digits of given decimal number. Example: 256  652*/

        public static void ReverseDigitsMethod(string number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }

            Console.WriteLine("Reversed number is {0}", sb.ToString());
        }

        static void Main()
        {
            Console.Write("Type a number: ");
            string input = Console.ReadLine();

            ReverseDigitsMethod(input);
        }
    }
}
