using System;
using System.Timers;

namespace CsharpConsole.Topics
{
    public class Timers
    {
        public void Execute()
        {
            var timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimer);
            timer.Interval = 2000;
            timer.Enabled = true;
            timer.AutoReset = true;

        }
        public static void OnTimer(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Datetime: " + DateTime.Now);
            Console.WriteLine("Raised: {0}", e.SignalTime);
        }
    }
}
