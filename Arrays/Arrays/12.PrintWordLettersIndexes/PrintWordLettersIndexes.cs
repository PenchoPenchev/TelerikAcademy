namespace _12.PrintWordLettersIndexes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class PrintWordLettersIndexes
    {
        static void Main()
        {
            /*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console
             * and print the index of each of its letters in the array.*/

            Console.Write("Type a word: ");
            string inputWord = Console.ReadLine();

            char[] inputCharWord = inputWord.ToCharArray();
            char[] alphabetLetters = new char[52];

            StringBuilder strBodyBuilder = new StringBuilder();

            // capital letters
            for (int i = 0; i < 26; i++)
            {
                alphabetLetters[i] = (char)(i + 65);
            }
            
            // small letters
            for (int i = 26; i < 52; i++)
            {
                alphabetLetters[i] = (char)(i + 71);
            }

            for (int i = 0; i < inputCharWord.Length; i++)
            {
                for (int ii = 0; ii < alphabetLetters.Length; ii++)
			    {
			        if (inputCharWord[i] == alphabetLetters[ii])
                    {
                        strBodyBuilder.Append(ii + " ");
                    }
			    }
            }

            Console.WriteLine(strBodyBuilder.ToString());
        }
    }
}
