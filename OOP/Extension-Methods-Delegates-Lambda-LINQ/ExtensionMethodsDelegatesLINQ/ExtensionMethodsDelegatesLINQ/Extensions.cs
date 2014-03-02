/*1. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
 * and has the same functionality as Substring in the class String.*/

/*2. Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extensions
    {
        #region task01

        public static string Substring(this StringBuilder sb, int index, int length)
        {
            string result = sb.ToString().Substring(index, length);

            return result;
        }

        #endregion

        #region task02

        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;

            foreach (var item in arr)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 1;

            foreach (var item in arr)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Minn<T>(this IEnumerable<T> arr)
        {
            dynamic min = int.MaxValue;

            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Maxx<T>(this IEnumerable<T> arr)
        {
            dynamic max = int.MinValue;

            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            int count = 0;

            foreach (var item in arr)
            {
                sum += item;
                count++;
            }

            dynamic average = sum / count;

            return average;
        }

        #endregion


    }
}
