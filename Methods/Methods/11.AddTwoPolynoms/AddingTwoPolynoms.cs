namespace _11.AddingTwoPolynoms
{
    using System;
    
    public class AddingTwoPolynoms
    {
        /*Write a method that adds two polynomials. 
         * Represent them as arrays of their coefficients as in the example below: x^2 + 5 = 1x^2 + 0x + 5 --> |5|0|1|*/

        public static decimal[] AddingPolynomials(decimal[] pol1, decimal[] pol2)
        {
            //Get bigger length for the result
            int maxLen = pol1.Length > pol2.Length ? pol1.Length : pol2.Length;

            //Get smaller length for the for cycle
            int minLen = pol1.Length > pol2.Length ? pol2.Length : pol1.Length;

            decimal[] result = new decimal[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                if (i <= minLen)
                {
                    result[i] = pol1[i] + pol2[i];
                }
                else
                {
                    if (pol1.Length > pol2.Length)
                    {
                        result[i] = pol1[i];
                    }
                    else
                    {
                        result[i] = pol2[i];
                    }
                }
            }

            return result;
        }

        public static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    if (polynomial[i] > 0)
                    {
                        Console.Write("+ {0}x^{1} ", polynomial[i], i);
                    }
                    else if (polynomial[i] < 0)
                    {
                        Console.Write("{0}x^{1} ", polynomial[i], i);
                    }
                }
                else
                {
                    if (polynomial[i] > 0)
                    {
                        Console.Write("+ {0}", polynomial[i]);
                    }
                    else if (polynomial[i] < 0)
                    {
                        Console.Write("{0}", polynomial[i]);
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            decimal[] firstPolynomial = { 5, -1, 0 };
            Console.Write("First polynomial:".PadRight(40));
            PrintPolynomial(firstPolynomial);

            decimal[] secondPolynomial = { 10, -5, 6 };
            Console.Write("Second polynomial:".PadRight(40));
            PrintPolynomial(secondPolynomial);

            Console.WriteLine();
            Console.Write("The sum of given polylonomials is:".PadRight(40));
            PrintPolynomial(AddingPolynomials(firstPolynomial, secondPolynomial));
        }
    }
}
