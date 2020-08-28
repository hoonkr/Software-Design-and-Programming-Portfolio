using System;
using System.ComponentModel.DataAnnotations;

namespace observer
{
    public class SMSUsers : IObserver
    {
        private ISubject _subject;
        private string userInfo;
        private string _desc;
        public SMSUsers(ISubject subject, string s)
        {
            _subject = subject;
            userInfo = s;
        }

        public void Update(string desc)
        {
            _desc = desc;
            Console.WriteLine("["+userInfo+"]: "+ desc);
        }

        

        public void Subscribe()
        {
            Console.WriteLine("Subscribing "+ userInfo +" to "+ _subject.SubjectDetails());
            _subject.SubscribeObserver(this);
            Console.WriteLine("Subscribed successfully.");
        }

        public void UnSubscribe()
        {
            Console.WriteLine("Unsubscribing "+ userInfo + " to "+_subject.SubjectDetails());
            _subject.UnSubscribeObserver(this);
            Console.WriteLine("Unsubscribed successfully.");
        }
    }
}