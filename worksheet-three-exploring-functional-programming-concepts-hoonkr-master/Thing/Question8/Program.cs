using System;
using System.Collections.Generic;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] tokens = line.Split();
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            
            segregateEvenOdd(numbers, numbers.Length);
            Console.WriteLine(string.Join(" ", numbers));
            
        }

        static void segregateEvenOdd(int[] arr, int n)
        {
            //current indexes from left and right
            int left = 0, right = n - 1;
            
            // count of even numbers
            int k = 0;

            while (left < right)
            {
                while (arr[left] % 2 == 0)
                {
                    left++;
                    k++;
                }

                while (arr[right] % 2 != 0 && left < right)
                {
                    right--;
                }

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
            
            Array.Sort(arr,0,k);
            Array.Sort(arr,k,n-k);
        }
    }
}