using System;

namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero", nameof(denominator));
            }
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);
        
        static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            return GreatestCommonDivisor(Math.Abs(b), Math.Abs(a) % Math.Abs(b));
        }
        public RationalNumber Abs()
        {
            return new RationalNumber(Math.Abs(Numerator),Math.Abs(Denominator)).Reduce();
        }

        public RationalNumber Reduce()
        {
            int gcd = GreatestCommonDivisor(Numerator, Denominator);
            int numerator = Numerator / gcd;
            int denominator = Denominator / gcd;
            if (denominator < 0)
            {
                return new RationalNumber(-numerator, - denominator );
            }
            return new RationalNumber(numerator, denominator);
        }

        public RationalNumber ExpRational(int power)
        {
            if (power < 0)
            {
                int m = Math.Abs(power);
                return new RationalNumber((int)Math.Pow(Denominator, m), (int)Math.Pow(Numerator, m)).Reduce();
            }
            else return new RationalNumber((int)Math.Pow(Numerator, power), (int)Math.Pow(Denominator, power)).Reduce();
        }

        public double ExpReal(int baseNumber)
        {
            return Math.Pow(baseNumber, (double) Numerator / (double) Denominator);
        }

        public RationalNumber Add(RationalNumber number)
        {
            return new RationalNumber((Numerator * number.Denominator) + (number.Numerator * Denominator), (number.Denominator * Denominator)).Reduce();
        }

        public RationalNumber Subtract(RationalNumber number)
        {
            return new RationalNumber((Numerator * number.Denominator) - (number.Numerator * Denominator) , number.Denominator * Denominator).Reduce();
        }

        public RationalNumber Multiply(RationalNumber number)
        {
            return new RationalNumber((Numerator * number.Numerator), (Denominator * number.Denominator)).Reduce();
        }

        public RationalNumber Divide(RationalNumber number)
        {
            if (Denominator == 0) throw new DivideByZeroException();
           
            return new RationalNumber((Numerator* number.Denominator), (Denominator * number.Numerator)).Reduce();
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj); // replace this with the correct expression or remove
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); // replace this with the correct expression or remove
        }

        // plus any other methods you deem necessary to meet the specification
    }

    public static class IntNumberExtension
    {
        // exponentiate real number to the rational number power
        public static double ExpReal(this int RealNumber, RationalNumber r)
        {
            return r.ExpReal(RealNumber);
        }
    }
}
