namespace _5.StringArraySorting
{
    using System;
    using System.Text;
    
    class StringArraySorts
    {
        static void Main()
        {
            /*You are given an array of strings. Write a method that sorts the array
             * by the length of its elements (the number of characters composing them).*/

            Console.WriteLine("Raw string");
            string[] strArray = { "the", "number", "of", "characters", "composing", "them" };

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted string by length of it's elements");
            strArray = StringArraySorting(strArray);

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] StringArraySorting(string[] strArray)
        {
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int ii = i + 1; ii < strArray.Length; ii++)
                {
                    if (strArray[i].Length > strArray[ii].Length)
                    {
                        string tempStr = strArray[i];
                        strArray[i] = strArray[ii];
                        strArray[ii] = tempStr;
                    }
                }
            }

            return strArray;
        }
    }
}
