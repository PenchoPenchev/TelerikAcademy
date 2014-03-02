namespace _8.AddTwoArrayNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class AddTwoArrayNumbers
    {
        /*Write a method that adds two positive integer numbers represented as arrays of digits
         * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
         * Each of the numbers that will be added could have up to 10 000 digits.*/

        public static void AddNumber(string a, string b)
        {
            int length = a.Length > b.Length ? a.Length : b.Length;

            StringBuilder sb = new StringBuilder();

            string aReversed = "";
            string bReversed = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                sb.Append(a[i]);
            }

            aReversed = sb.ToString();
            sb.Clear();

            for (int i = b.Length - 1; i >= 0; i--)
            {
                sb.Append(b[i]);
            }

            bReversed = sb.ToString();
            sb.Clear();
           
            List<int> arrSum = new List<int>();
            int carry = 0;
            int aLength = a.Length - 1;
            int bLength = b.Length - 1;
            
            for (int i = 0; i < length; i++)
            {
                if (aLength >= i && bLength >= i)
                {
                    if ((int.Parse(aReversed[i].ToString()) + int.Parse(bReversed[i].ToString()) + carry) > 9 && i <= aLength && i <= bLength)
                    {
                        arrSum.Add(0);
                        carry = 1;
                    }
                    else if ((int.Parse(aReversed[i].ToString()) + int.Parse(bReversed[i].ToString()) + carry) <= 9)
                    {
                        arrSum.Add(int.Parse(aReversed[i].ToString()) + int.Parse(bReversed[i].ToString()) + carry);
                        carry = 0;
                    }
                    else if ((int.Parse(aReversed[i].ToString()) + int.Parse(bReversed[i].ToString()) + carry) > 9 && i == length - 1)
                    {
                        arrSum.Add(10);
                        carry = 0;
                    }
                }
                else
                {
                    if (a.Length > b.Length)
                    {
                        arrSum.Add(int.Parse(aReversed[i].ToString()));
                    }
                    else
                    {
                        arrSum.Add(int.Parse(bReversed[i].ToString()));
                    }
                }
            }

            arrSum.Reverse(0, arrSum.Count);
            Console.WriteLine(String.Join("",arrSum));
        }

        static void Main()
        {
            Console.Write("First number = ");
            string firstNumber = Console.ReadLine();

            Console.Write("Second number = ");
            string secondNumber = Console.ReadLine();

            AddNumber(firstNumber, secondNumber);
        }
    }
}
