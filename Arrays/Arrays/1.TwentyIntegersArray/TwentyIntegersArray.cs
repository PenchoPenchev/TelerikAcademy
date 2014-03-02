namespace _1.TwentyIntegersArray
{
    using System;
    using System.Text;

    class TwentyIntegersArray
    {
        static void Main()
        {
            /*Write a program, which creates an array of  20 elements of type 
             * integer  and initializes each of the elements with a value equals to the 
             * index of the element multiplied by 5. Print the elements to the console. */
            int[] arr = new int[20];

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                builder.AppendLine((i * 5).ToString());
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
