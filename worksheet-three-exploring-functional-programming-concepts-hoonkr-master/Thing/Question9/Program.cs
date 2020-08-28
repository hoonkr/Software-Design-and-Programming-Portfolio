using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Question9
{
    class Program
    {
        static int greatestCommonDivisor(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : greatestCommonDivisor(Math.Abs(b), Math.Abs(a) % Math.Abs(b));
        }

        static int LCM(int[] numbers)
        {
            var res = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                res = res * numbers[i] / greatestCommonDivisor(res, numbers[i]);
            }

            return res;
        }
        
        static void Main(string[] args)
        {
           var n = Console.ReadLine();
           var result = int.Parse(n);
           var list = Enumerable.Range(0, result + 1);

           var line = Console.ReadLine();
           string[] tokens = line.Split();
           int[] numbers = Array.ConvertAll(tokens, int.Parse);
    
           
           long lcm_value = LCM(numbers);
           // Console.WriteLine(lcm_value);

           Func<int, bool> is_gcd = x => x % lcm_value == 0;
           var gcd = list.Where(is_gcd);
           // gcd.ToList().ForEach(Console.WriteLine);
           Console.WriteLine("{0}", string.Join(" ", gcd));
        }
        
    }
}