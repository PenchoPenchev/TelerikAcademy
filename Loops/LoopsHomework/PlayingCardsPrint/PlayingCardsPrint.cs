namespace PlayingCardsPrint
{
    using System;

    class PlayingCardsPrint
    {
        static void Main(string[] args)
        {
            /*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be
             * printed with their English names. Use nested for loops and switch-case.*/

            Console.WriteLine("All playing cards without the jokers.");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    switch (j)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            Console.Write(j);
                            break;
                        case 11:
                            Console.Write("Jack");
                            break;
                        case 12:
                            Console.Write("Queen");
                            break;
                        case 13:
                            Console.Write("King");
                            break;
                        case 14:
                            Console.Write("Ace");
                            break;
                        default:
                            break;
                    }
                    
                    switch (i)
                    {
                        case 0:
                            Console.Write(" of Clubs");
                            break;
                        case 1:
                            Console.Write(" of Diamonds");
                            break;
                        case 2:
                            Console.Write(" of Hearts");
                            break;
                        case 3:
                            Console.Write(" of Spades");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
