using System;
using System.Collections.Generic;
using System.Linq;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> add = x => x + 1;
            Func<int, int> mult = x => x * 2;
            Func<int, int> negate = x => x - 1;
            
            
  

            var line = Console.ReadLine();
            string[] tokens = line.Split();
            int[] array = Array.ConvertAll(tokens, int.Parse);
            
            List<int> list = array.OfType<int>().ToList();


            while (true) // Loop indefinitely
            { 
                string state = Console.ReadLine(); // Get string from user
                if (state == "end") // Check string
                {
                    Console.WriteLine("{0}", string.Join(" ", list));
                    break;
                }
                switch (state)
                {
                    case "add":
                    {
                        var plusone = list.Select(add);
                        list = plusone.ToList();
                        break;
                    }
                    case "subtract":
                    {
                        var minone = list.Select(negate);
                        list = minone.ToList();
                        break;
                    }
                    case "multiply":
                    {
                        var multi = list.Select(mult);
                        list = multi.ToList();
                        break;
                    }
                }
            }
        }
    }
}