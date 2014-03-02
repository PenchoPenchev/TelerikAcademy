/*8. * Read in MSDN about the keyword event in C# and how to publish events. 
 * Re-implement task 7 using .NET events and following the best practices.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Task08Test
    {
        public static int interval = 2;
        public static int duration = 10;

        public static void Test()
        {
            Timer timer = new Timer();

            timer.RepeatSomeMethod(Print, interval, duration);
        }

        public static void Print()
        {
            Console.WriteLine("This text will be repeated {0} times.", duration / interval);
        }
    }
}
