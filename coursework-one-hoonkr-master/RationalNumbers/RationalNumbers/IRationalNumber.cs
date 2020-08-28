using System;
namespace RationalNumbers
{
    public interface IRationalNumber
    {
        RationalNumber Add(RationalNumber number);
        RationalNumber Subtract(RationalNumber number);
        RationalNumber Multiply(RationalNumber number);
        RationalNumber Divide(RationalNumber number);
        RationalNumber Abs();
        RationalNumber ExpRational(int power);
        double ExpReal(int baseNumber);
        // anything else you need to add?
    }
}
