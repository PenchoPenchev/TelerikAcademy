namespace _4.FoundNumberInArray
{
    using System;
    using System.Collections.Generic;
    
    public class FoundNumberInArray
    {
        public static double numberToBeChecked;
        public static int counter;
        
        public static void DoCountArrayNumbers(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToBeChecked)
                {
                    counter++;
                }  
            }

            Console.WriteLine("Number {0} is found {1} times.", numberToBeChecked, counter);
        }
        
        static void Main()
        {
            /*Write a method that counts how many times given number appears in given array. 
             * Write a test program to check if the method is working correctly.*/

            Console.Write("Check number: ");
            numberToBeChecked = double.Parse(Console.ReadLine());

            double[] array = { 2, 3, 2, 4, 3, 2, 1, 5, 5, 4};
            
            DoCountArrayNumbers(array);
        }
    }
}
