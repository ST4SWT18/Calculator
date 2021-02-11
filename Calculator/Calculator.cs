using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return Math.Round(a + b, 1);
        }

        public double Subtract(double a, double b)
        {
            return Math.Round(a - b, 1);
        }

        public double Multiply(double a, double b)
        {
            return Math.Round(a * b, 1);
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException();
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Root(double x, double root)
        {
            if (root != 0 && x>=0)
                return Math.Pow(x, 1.0 / root);
            else
                throw new Exception();
        }
    }
}