/*6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
 * Use the built-in extension methods and lambda expressions. 
 * Rewrite the same with LINQ.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task06Test
    {
        public static void Test()
        {
            List<int> arr = new List<int>() { 1, 3, 14, 21, 42, 55, 84 };

            //Lambda expression
            var lambdaNumbers = arr.FindAll(x => (x % 21 == 0));

            Console.WriteLine("Lambda expression result");
            lambdaNumbers.ToList().ForEach(Console.WriteLine);

            //LINQ
            var linqNumbers =
                from a in arr
                where a % 21 == 0
                select a;

            Console.WriteLine("LINQ result");
            linqNumbers.ToList().ForEach(Console.WriteLine);
        }
    }
}
