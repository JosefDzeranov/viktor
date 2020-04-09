using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Class_App
{
    public class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denomitator)
        {
            Numerator = numerator;
            Denominator = denomitator;
            Normalize();
        }
        public  Fraction Summation(Fraction fraction)
        {
            return new Fraction(Numerator * fraction.Denominator + fraction.Numerator * Denominator, Denominator * Denominator);
        }
        public Fraction Deduction(Fraction fraction)
        {
            return new Fraction(Numerator *  fraction.Denominator -  fraction.Numerator * Denominator, Denominator * fraction.Denominator);
        }
        public Fraction Multiplication(Fraction fraction)
        {
            return new Fraction(Numerator * fraction.Numerator, Denominator * fraction.Denominator);
        }
        public Fraction Separation(Fraction fraction)
        {
            return new Fraction(Numerator * fraction.Denominator, fraction.Numerator * Denominator);
        }

        private static int GCD(int m, int n) //Greatest Common Divizior
        {
            if (m == 0)
                return 0;
            if (n == 0 || n == m)
                return m;
            if (m == 1 || n == 1)
                return 1;
            bool mIsOdd = (m & 1) == 0;
            bool nIsOdd = (n & 1) == 0;
            if (mIsOdd && nIsOdd)
                return 2 * GCD(m >> 1, n >> 1);
            if (mIsOdd)
                return GCD(m >> 1, n);
            if (nIsOdd)
                return GCD(m, n >> 1);
            int max = Math.Max(m, n), min = Math.Min(m, n);
            return GCD((max - min) >> 1, min);
        }
        private Fraction Normalize()
        {
            if (Numerator == 0)
                return new Fraction(0, 1);
            int gcd = GCD(Numerator, Denominator);
            if (gcd > 1)
            {
                Numerator /= gcd;
                Denominator /= gcd;
            }
            return this;
        }

        public double ConvertToDouble()
        {
            return Numerator / (double)Denominator;
        }
        public string Print()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }
    }
}
