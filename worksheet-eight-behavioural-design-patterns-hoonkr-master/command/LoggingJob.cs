using System;
using System.Threading;

namespace command
{
    public class LoggingJob : IJob
    { 
        public Logging Logging { set; get; }

        public void Run()
        {
            Console.WriteLine("Job ID: "+ Thread.CurrentThread.ManagedThreadId+" executing logging jobs.");
            if (Logging != null)
            {
                Logging.Log();
            }

            try
            {
                Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException)
            {
                Thread.CurrentThread.Interrupt();
            }
        }
    }
}