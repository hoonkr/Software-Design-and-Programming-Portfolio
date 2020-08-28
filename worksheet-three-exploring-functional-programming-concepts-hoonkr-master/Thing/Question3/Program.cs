using System;
using System.Collections.Generic;
using System.Linq;

namespace Question3
{
    class Program 
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] tokens = line.Split();
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            var list = numbers.OfType<int>().ToList();

            var minNumber = list.Min();
            
            Console.WriteLine(minNumber);
        }
        
    }
}