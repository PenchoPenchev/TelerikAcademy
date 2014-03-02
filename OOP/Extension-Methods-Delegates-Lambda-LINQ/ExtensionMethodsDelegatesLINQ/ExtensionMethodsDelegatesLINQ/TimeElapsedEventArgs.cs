namespace TasksFrom1to7
{
    using System;

    public delegate void TimeElapsedEventHandler(object sender, TimeElapsedEventArgs e);

    public class TimeElapsedEventArgs : EventArgs
    {
        public int TicksLeft { get; private set; }

        public TimeElapsedEventArgs(int ticksLeft)
        {
            this.TicksLeft = ticksLeft;
        }
    }
}
