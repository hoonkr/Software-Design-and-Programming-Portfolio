using System.Collections.Generic;
using System;
using System.IO;

namespace QuestionFive
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();
        private Singleton(){}


        public static Singleton GetInstance
        {
            get { return instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been called");
        }
    }
}