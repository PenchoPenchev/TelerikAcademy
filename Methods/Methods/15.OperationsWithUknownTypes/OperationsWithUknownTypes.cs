namespace _15.OperationsWithUknownTypes
{
    using System;
    using System.Collections.Generic;

    class OperationsWithUknownTypes
    {
        /** Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
         * Use generic method (read in Internet about generic methods in C#).*/

        public static T CalcMinimum<T>(params T[] elements)
        {
            dynamic min = 0;

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
            return min;
        }

        public static T CalcMaximum<T>(params T[] elements)
        {
            dynamic max = 0;

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
            return max;
        }

        public static T CalcAverage<T>(params T[] elements)
        {
            dynamic sum = 0;
            dynamic average = 0;

            foreach (var element in elements)
            {
                sum += element;
            }

            average = sum / elements.Length;

            Console.WriteLine("The average value is '{0}'", average);
            return average;
        }

        public static T CalcSum<T>(params T[] elements)
        {
            dynamic sum = 0;

            foreach (var element in elements)
            {
                sum += element;
            }

            Console.WriteLine("The sum is '{0}'", sum);
            return sum;
        }

        public static T CalcProduct<T>(params T[] elements)
        {
            dynamic product = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }

            Console.WriteLine("The product is '{0}'", product);
            return product;
        }

        static void Main()
        {
            //Print like integers
            Console.WriteLine("Print like integers");
            CalcMinimum(1, 2, 3, 4);
            CalcMaximum(1, 2, 3);
            CalcAverage(1, 2, 3, 4, 5);
            CalcSum(1, 2, 3, 4, 5, 6);
            CalcProduct(2, 3);
            Console.WriteLine("Print like decimals");
            CalcMinimum(1m, 2m, 3m, 4m);
            CalcMaximum(1m, 2m, 3m);
            CalcAverage(1m, 2m, 3m, 4m, 5m);
            CalcSum(1m, 2m, 3m, 4m, 5m, 6m);
            CalcProduct(2m, 3m);
            Console.WriteLine("Print like floats");
            CalcMinimum(1f, 2f, 3f, 4f);
            CalcMaximum(1f, 2f, 3f);
            CalcAverage(1f, 2f, 3f, 4f, 5f);
            CalcSum(1f, 2f, 3f, 4f, 5f, 6f);
            CalcProduct(2f, 3f);
        }
    }
}
