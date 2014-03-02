/*7. Using delegates write a class Timer that has can execute certain method at each t seconds.*/

/*8. * Read in MSDN about the keyword event in C# and how to publish events. 
 * Re-implement task 7 using .NET events and following the best practices.*/

namespace TasksFrom1to7
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    
    public class Timer
    {
        // The event that will be raised when time elapses
        public event TimeElapsedEventHandler TimeElapsed;
        
        public delegate void TimerDelegate();

        protected void OnTimeElapsed(int seconds)
        {
            if (TimeElapsed != null)
            {
                TimeElapsedEventArgs e = new TimeElapsedEventArgs(seconds);
                TimeElapsed(this, e);
            }
        }

        public void RepeatSomeMethod(TimerDelegate method, int seconds, long durationInSeconds)
        {
            long start = 0;

            while (start <= durationInSeconds)
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
                OnTimeElapsed(seconds);  
            }
        }
    }
}
