/*7. Using delegates write a class Timer that has can execute certain method at each t seconds.*/

namespace TasksFrom1to7
{
    using System;
    
    public static class Task07Test
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
            Console.WriteLine("This text will be repeated {0} times.", duration/interval);
        }
    }
}
