namespace _14.OperationsWithUknownVariables
{
    using System;

    class OperationsWithUknownVariables
    {
        /*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
         * Use variable number of arguments.*/

        public static void CalcMinimum(params int[] elements)
        {
            int min = 0;

            foreach (var element in elements)
            {
                if (min == 0)
                {
                    min = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            Console.WriteLine("The smallest integer is '{0}'", min);
        }

        public static void CalcMaximum(params int[] elements)
        {
            int max = 0;

            foreach (var element in elements)
            {
                if (max == 0)
                {
                    max = element;
                }
                else if (element > max)
                {
                    max = element;
                }
            }

            Console.WriteLine("The biggest integer is '{0}'", max);
        }

        public static void CalcAverage(params int[] elements)
        {
            int sum = 0;
            double average = 0;

            foreach (var element in elements)
            {
                sum += element;
            }

            average = sum / elements.Length;

            Console.WriteLine("The average value is '{0}'", average);
        }

        public static void CalcSum(params int[] elements)
        {
            int sum = 0;

            foreach (var element in elements)
            {
                sum += element;
            }

            Console.WriteLine("The sum is '{0}'", sum);
        }

        public static void CalcProduct(params int[] elements)
        {
            long product = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }

            Console.WriteLine("The product is '{0}'", product);
        }

        static void Main()
        {
            CalcMinimum(2, 3, 4, 2, 8, 9, 15, 19, 4, 5);
            CalcMaximum(2, 3, 4, 2, 8, 9, 15, 19, 4, 5);
            CalcAverage(2, 3, 4, 2, 8, 9, 15, 19, 4, 5);
            CalcSum(2, 3, 4, 2, 8, 9, 15, 19, 4, 5);
            CalcProduct(2, 3, 4, 2, 8, 9, 15, 19, 4, 5);
        }
    }
}
