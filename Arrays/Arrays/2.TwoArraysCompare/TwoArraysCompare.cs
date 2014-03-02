namespace _2.TwoArraysCompare
{
    using System;
    using System.Text;

    class TwoArraysCompare
    {
        static void Main(string[] args)
        {
            /*Write a program, which reads two arrays from the console and checks 
             * whether they are equal (two arrays are equal when they are of equal 
             * length and all of their elements, which have the same index, are equal).*/

            Console.Write("arr1 lenght is = ");
            int[] arr1 = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr1[{0}] = ", i);
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("arr2 lenght is = ");
            int[] arr2 = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr2[{0}] = ", i);
                arr2[i] = Int32.Parse(Console.ReadLine());
            }

            bool areEquals = true;

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        areEquals = false;
                    }
                }
            }
            else
            {
                areEquals = false;
            }

            Console.WriteLine(areEquals ? "arr1 and arr2 are equals" : "arr1 and arr2 are Not equals");
        }
    }
}
