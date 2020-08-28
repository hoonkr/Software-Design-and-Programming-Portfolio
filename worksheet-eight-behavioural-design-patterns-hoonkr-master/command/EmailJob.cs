using System;
using System.Threading;

namespace command
{
    public class EmailJob : IJob
    {
        private Email _email;
        public void Run()
        {
            Console.WriteLine("Job ID: "+Thread.CurrentThread.ManagedThreadId+" executing email jobs.");
            if (_email != null)
            {
                _email.SendEmail();
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

        public void Email(Email email)
        {
            _email = email;
        }
    }
}