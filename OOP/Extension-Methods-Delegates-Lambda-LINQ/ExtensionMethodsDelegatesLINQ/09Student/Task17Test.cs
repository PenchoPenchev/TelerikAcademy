/*17. Write a program to return the string with maximum length from an array of strings. Use LINQ.*/

namespace _09Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public static class Task17Test
    {
        private static int longestElement = 0;
        
        public static void Test()
        {
            string str = "Write a program to return the string with maximum length from an array of strings";

            string[] arr = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var findMaxLength =
                from a in arr
                where GetMaxLengthStr(a)
                select a;
        }

        private static bool GetMaxLengthStr(string a)
        {
            if (a.Length > longestElement)
            {
                longestElement = a.Length;
                return true;
            }
            return false;
        }
    }
}
