using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace Thing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sir = "Sir ";

            var line = Console.ReadLine();
            string[] tokens = line.Split();
          
            var list = tokens.OfType<string>().ToList();

            list.ForEach(delegate(String knig) { Console.WriteLine(sir+ knig); });
            
        }

    }

}