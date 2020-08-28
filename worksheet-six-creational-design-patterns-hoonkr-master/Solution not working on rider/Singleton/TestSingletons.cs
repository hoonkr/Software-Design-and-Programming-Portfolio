using System;

namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.DoSomething();
            
            LazySingleton lazySingleton = LazySingleton.Instance;
            lazySingleton.DoSomething();
        }
    }
}