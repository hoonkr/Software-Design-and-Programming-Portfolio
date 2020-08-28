using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Question4
{
    class Program
    {
       static void Main(string[] args)
        {
            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, bool> isOdd = x => x % 2 == 1;
            
            var rangeinput = Console.ReadLine();
            string[] tokens = rangeinput.Split();
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            
            var list = Enumerable.Range(numbers[0], numbers[1] - numbers[0]);
            var userinput = Console.ReadLine();
           
            if (userinput == "even")
            {
                var even = list.Where(isEven);
                Console.WriteLine("{0}", string.Join(" ", even));
            }
            else if (userinput == "odd")
            {
                var odd = list.Where(isOdd);
                Console.WriteLine("{0}", string.Join(" ", odd));
            }

            
        }
    }
}