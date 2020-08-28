using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;

namespace observer
{
    public class CommentaryObject : ISubject, ICommentary
    {
        private List<IObserver> _observers;
        private string subjectDetail;
        private string _desc;
        public CommentaryObject(List<IObserver> observers, string s)
        {
            _observers = observers;
            subjectDetail = s;
        }

        public void SubscribeObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribeObserver(IObserver observer)
        {
            int index = _observers.IndexOf(observer);
            _observers.RemoveAt(index);
        }

        public void NotifyObservers()
        {
            Console.WriteLine();
            foreach (IObserver observer in _observers)
            {
                observer.Update(_desc);
            }
        }

        public string SubjectDetails()
        {
            return subjectDetail;
        }

        public void Description (string desc)
        {
            _desc = desc;
            NotifyObservers();
        }
    }
}