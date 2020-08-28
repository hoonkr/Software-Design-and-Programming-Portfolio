using System;
using System.Threading;

namespace command
{
    public class SmsJob : IJob
    {
        private Sms _sms;
        public void Run()
        {
            Console.WriteLine("Job ID: "+ Thread.CurrentThread.ManagedThreadId +" executing sms jobs");
            if (_sms != null)
            {
                _sms.SendSms();
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

        public void Sms(Sms sms)
        {
            _sms = sms;
        }
    }
}