using System;

namespace QuestionFive
{
    public class LazySingleton
    {
        private static LazySingleton instance = null;
        
        private LazySingleton(){}

        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }

                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("LazySingleton class code has been called");
        }
    }
}