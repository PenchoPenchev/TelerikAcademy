namespace _1.AskForTheName
{
    using System;

    class AskForTheName
    {
        /*Write a method that asks the user for his name and prints “Hello, <name>” 
         * (for example, “Hello, Peter!”). Write a program to test this method.*/
        public static void AskAndPrintName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
        
        static void Main(string[] args)
        {
            AskAndPrintName();
        }
    }
}
