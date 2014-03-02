namespace _3.CompareArraysLexicographically
{
    using System;
    using System.Text;

    class CompareArraysLexicographically
    {
        static void Main(string[] args)
        {
            /*Write a program, which  compares two arrays of  type  char 
             * lexicographically (character by character) and checks, which one is first 
             * in the lexicographical order. */

            Console.Write("Type a word: ");
            string word1 = Console.ReadLine();

            char[] word1CharArray = word1.ToCharArray();

            Console.Write("Type a second word: ");
            string word2 = Console.ReadLine();

            char[] word2CharArray = word2.ToCharArray();

            int iterations = Math.Min(word1CharArray.Length, word2CharArray.Length); // get the the lower array length

            for (int i = 0; i < iterations; i++)
            {
                if (word1CharArray[i] != word2CharArray[i])
                {
                    Console.WriteLine(word1CharArray[i].CompareTo(word2CharArray[i]) == 1 ? "{0} is more lexicographical {1}" : "{1} is more lexicographical than {0}", word2, word1);
                    break;
                }
                else if (i == iterations - 1 && word1CharArray.Length != word2CharArray.Length)
                {
                    Console.WriteLine(word1CharArray.Length > word2CharArray.Length ? "{0} is more lexicographical {1}" : "{1} is more lexicographical than {0}", word2, word1);
                }
                else if (i == iterations - 1 && word1CharArray.Length == word2CharArray.Length)
                {
                    Console.WriteLine("{0} and {1} are even lexicographical", word1, word2);
                }
            }
        }
    }
}
