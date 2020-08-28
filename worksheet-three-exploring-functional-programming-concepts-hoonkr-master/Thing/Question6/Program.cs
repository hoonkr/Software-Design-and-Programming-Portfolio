using System;
using System.Collections.Generic;
using System.Linq;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] tokens = line.Split();
            int[] array = Array.ConvertAll(tokens, int.Parse);
            
            List<int> list = array.OfType<int>().ToList();
          
            list.Reverse();

            var somestring = Console.ReadLine();
            var result = int.Parse(somestring);

            list.RemoveAll(x => x % result == 0);
            
            Console.WriteLine("{0}", string.Join(" ", list));



        }
    }
}