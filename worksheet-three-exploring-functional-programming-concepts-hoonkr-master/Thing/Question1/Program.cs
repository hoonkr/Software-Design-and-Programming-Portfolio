using System;
using System.Collections.Generic;
using System.Linq;


namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] tokens = line.Split();
          
            List<string> list = tokens.OfType<string>().ToList();
            
            list.ForEach(delegate(string number) { Console.WriteLine(number); });
        }
    }
}