using System;
using System.Threading.Channels;

namespace Question_1
{
    using static Math;

    public enum BmiRange
    {
        Underweight,
        Healthy,
        Overweight
    }
    
    public static class BMI
    {

        public static void Run(Func<string, double> read, Action<BmiRange> write)
        {
            var weight = read("weight");
            var height = read("height");

            var bmiRange = CalculateBmi(height, weight).ToBmiRange();

            write(bmiRange);
        }

        public static double CalculateBmi(double height, double weight)
            => Round(weight / Pow(height, 2), 2);

        public static BmiRange ToBmiRange(this double bmi)
            => bmi < 18.5 ? BmiRange.Underweight
                : 25 <= bmi ? BmiRange.Overweight
                : BmiRange.Healthy;

        public static double Read(string field)
        {
            Console.WriteLine($"Please enter your {field}: ");
            return double.Parse(Console.ReadLine() ?? "");
        }

        private static void Write(BmiRange bmiRange)
            => Console.WriteLine($"Based on your BMI, you are {bmiRange}");
    }
}