/*2. Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    
    public static class Task02Test
    {
        public static void Test()
        {
            List<int> someNumbers = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("List<int> someNumbers = new List<int>() { 1, 2, 3, 4, 5 };");

            var sum = someNumbers.Sum();
            Console.WriteLine("Sum {0}", sum);

            var product = someNumbers.Product();
            Console.WriteLine("Product {0}", product);

            var min = someNumbers.Minn();
            Console.WriteLine("Min {0}", min);

            var max = someNumbers.Maxx();
            Console.WriteLine("Max {0}", max);

            var average = someNumbers.Average();
            Console.WriteLine("Average {0}", average);
        }
    }
}
