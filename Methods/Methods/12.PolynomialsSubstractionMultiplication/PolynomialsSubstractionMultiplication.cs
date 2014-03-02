namespace _12.PolynomialsSubstractionMultiplication
{
    using System;
    using _11.AddingTwoPolynoms;

    class PolynomialsSubstractionMultiplication
    {
        /*Extend program from exercise 11 to support also subtraction and multiplication of polynomials.*/
        public static decimal[] SubstractPolynomials(decimal[] pol1, decimal[] pol2)
        {
            //Get bigger length for the result
            int maxLen = pol1.Length > pol2.Length ? pol1.Length : pol2.Length;

            //Get smaller length for the for cycle
            int minLen = pol1.Length > pol2.Length ? pol2.Length : pol1.Length;

            decimal[] result = new decimal[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                if (i < minLen)
                {
                    if (pol1[i] != 0 && pol2[i] != 0)
                    {
                        result[i] = pol1[i] - pol2[i];    
                    }
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

        public static decimal[] MultiplyPolynomials(decimal[] pol1, decimal[] pol2)
        {
            decimal[] result = new decimal[pol1.Length + pol2.Length];

            for (int left = 0; left < pol1.Length; left++)
            {
                for (int right = 0; right < pol2.Length; right++)
                {
                    int position = left + right;
                    result[position] += (pol1[left] * pol2[right]);
                }
            }

            return result;
        }
        
        static void Main()
        {
            decimal[] firstPolynomial = { 8, 1, 3 };
            Console.Write("First polynomial:".PadRight(30));
            AddingTwoPolynoms.PrintPolynomial(firstPolynomial);

            decimal[] secondPolynomial = { 3, -1, 4, -3, -2 };
            Console.Write("Second polynomial:".PadRight(30));
            AddingTwoPolynoms.PrintPolynomial(secondPolynomial);

            Console.WriteLine();
            Console.Write("Substraction:".PadRight(30));
            AddingTwoPolynoms.PrintPolynomial(SubstractPolynomials(firstPolynomial, secondPolynomial));

            Console.Write("Multiplication:".PadRight(30));
            AddingTwoPolynoms.PrintPolynomial(MultiplyPolynomials(firstPolynomial, secondPolynomial));
        }
    }
}
