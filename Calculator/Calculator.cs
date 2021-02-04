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

        public double Power(double x, double exp)
        {
            return Math.Round(Math.Pow(x, exp), 1);
        }
        //HEJ med dig
    }
}