using System;
using System.Collections.Generic;
using System.Linq;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = int.Parse(input);
            Func<string, bool> strLength = delegate(string name) { return name.Length <= result; };
            
            
            var line = Console.ReadLine();
            string[] tokens = line.Split();

            List<string> list = tokens.OfType<string>().ToList();
            
            var filteredList = list.Where(strLength);
            filteredList.ToList().ForEach(Console.WriteLine);
        }
    }
}