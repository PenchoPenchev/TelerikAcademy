using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace FallingRocksByMe
{
    class FallingRocksByMe
    {
        struct Element
        {
            public int coordX;
            public int coordY;
            public char symbol;
            public ConsoleColor color;
        }

        //Print rocks rock by rock on the screen and the info separation line 
        public static void PrintOnPosition(int coordX, int coordY, char symbol, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        //This method is used to draw some text information on the Console
        static void PrintStringOnPosition(int coordX, int coordY, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            byte playfieldWidth = 27;
            byte livesCount = 10;
            int score = 0;
            int speed = 0;

            //set console size
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;

            //creating object to struct Element
            Element dwarf = new Element();

            //set initial screen coords and style to object dwarf
            dwarf.coordX = 13;
            dwarf.coordY = Console.WindowHeight - 1;
            dwarf.symbol = 'O';
            dwarf.color = ConsoleColor.White;

            Random randomGenerator = new Random();

            //creating a generic instance of Element struct, which will collect all new rocks
            List<Element> rocks = new List<Element>();

            //PrintOnPosition(dwarf.coordX, dwarf.coordY, dwarf.symbol, dwarf.color);

            while (livesCount <= 0)
            {
                bool hitted = false;

                //creating rocks
                {
                    //creating newRock instance to Element struct
                    Element newRock = new Element();

                    //creating char array with required symbols
                    char[] symbol = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    byte randomSymbol = (byte)randomGenerator.Next(0, symbol.Length);
                    byte rockLength = (byte)randomGenerator.Next(1, 3);

                    newRock.coordX = randomGenerator.Next(0, playfieldWidth);
                    newRock.coordY = 0;
                    newRock.color = (ConsoleColor)randomGenerator.Next(9, 15);
                    newRock.symbol = symbol[randomSymbol];

                    //adding new rock in the rocks collection 
                    for (int i = 0; i < rockLength; i++)
                    {
                        newRock.coordX = newRock.coordX + i;
                        if (newRock.coordX < playfieldWidth)
                        {
                            rocks.Add(newRock);
                        }
                    }
                }
                //end creating rocks

                // Move dwarf left or right after arrow key pressed
                if (Console.KeyAvailable)
                {
                    //creating read key instance
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                    //left arrow pressed
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.coordX - 1 >= 1)
                        {
                            dwarf.coordX--;
                        }
                    }
                    //right arrow pressed
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.coordX + 1 < playfieldWidth - 1)
                        {
                            dwarf.coordX++;
                        }
                    }
                }

                //moving rocks
                List<Element> movingRocks = new List<Element>();

                for (int i = 0; i < rocks.Count; i++)
                {
                    Element oldRock = rocks[i];
                    Element newRock = new Element();

                    newRock.coordX = oldRock.coordX;
                    newRock.coordY = oldRock.coordY + 1;
                    newRock.symbol = oldRock.symbol;
                    newRock.color = oldRock.color;

                    //checking if the dwarf is hitted
                    if ((newRock.coordY == dwarf.coordY))
                    {
                        if ((newRock.coordX == dwarf.coordX - 1)||(newRock.coordX == dwarf.coordX)||(newRock.coordX == dwarf.coordX + 1))
                        {
                            hitted = true;
                            livesCount--;
                        }
                    }

                    if (newRock.coordY < Console.WindowHeight)
                    {
                        movingRocks.Add(newRock);
                    }
                    else
                    {
                        score++;
                    }
                }

                //rocks collection gets the new positions on the same rocks + new generated above them
                rocks = movingRocks;

                //clear the console
                Console.Clear();

                //Draw "Game over"
                if (livesCount <= 0)
                {
                    PrintStringOnPosition(17, 8, "GAME OVER !!!", ConsoleColor.Red);
                    PrintStringOnPosition(12, 16, "Your score is :" + score, ConsoleColor.Red);
                    PrintStringOnPosition(14, 24, "Press [Enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    return;

                }

                //Redraw playfield - separate console screen by height
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(playfieldWidth, i, '|', ConsoleColor.White);
                }

                foreach (Element rock in rocks)
                {
                    PrintOnPosition(rock.coordX, rock.coordY, rock.symbol, rock.color);
                }

                if (hitted)
                {
                    PrintOnPosition(dwarf.coordX, dwarf.coordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.coordX - 1, dwarf.coordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.coordX + 1, dwarf.coordY, 'H', ConsoleColor.Red);
                    rocks.Clear();
                    PrintStringOnPosition(32, 3, "Press [Enter]", ConsoleColor.Green);
                    PrintStringOnPosition(33, 5, "to continue", ConsoleColor.Green);
                    speed = 0;
                    Console.ReadLine();
                }
                else
                {
                    PrintOnPosition(dwarf.coordX, dwarf.coordY, dwarf.symbol, dwarf.color);
                    PrintOnPosition(dwarf.coordX - 1, dwarf.coordY, '(', dwarf.color);
                    PrintOnPosition(dwarf.coordX + 1, dwarf.coordY, ')', dwarf.color);
                }

                //Player info - lives, speed and score
                PrintStringOnPosition(35, 8, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(35, 16, "Speed: " + speed / 20, ConsoleColor.White);
                PrintStringOnPosition(33, 24, "Score: " + score, ConsoleColor.White);

                // Slow down program
                if (speed < 100)
                {
                    speed++;
                }
                Thread.Sleep(250 - speed);
            }

            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;
        }
    }
}
