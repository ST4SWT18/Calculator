using System;
using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class Tests
    {
        Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(50, 20, 30)]
        [TestCase(51, 20.5, 30.5)]
        [TestCase(4, 1.7, 2.3)]
        [TestCase(-11.2, -1.9, -9.3)]
        public void Add_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double sum = uut.Add(a, b);

            Assert.That(sum, Is.EqualTo(exp));
        }

        [TestCase(-10, 20, 30)]
        [TestCase(-10, 20.5, 30.5)]
        [TestCase(-0.6, 1.7, 2.3)]
        [TestCase(7.4, -1.9, -9.3)]
        public void Subtract_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double difference = uut.Subtract(a, b);

            Assert.That(difference, Is.EqualTo(exp).Within(1E-15));
        }

        [TestCase(600, 20, 30)]
        [TestCase(625.2, 20.5, 30.5)]
        [TestCase(3.9, 1.7, 2.3)]
        [TestCase(9, -2, -4.5)]
        public void Multiply_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double product = uut.Multiply(a, b);

            Assert.That(product, Is.EqualTo(exp).Within(1E-15));
        }

        [TestCase(0.666, 20, 30)]
        [TestCase(0.672, 20.5, 30.5)]
        [TestCase(0.739, 1.7, 2.3)]
        [TestCase(0.444, -2, -4.5)]
        public void Divide_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double result = uut.Divide(a, b);

            Assert.That(result, Is.EqualTo(exp).Within(1E-2));
        }

        [TestCase(2, 0)]
        [TestCase(-6, 0)]
        [TestCase(72, 0)]
        [TestCase(0, 0)]
        public void Divide_TwoNumbers_AndReturnExp_ExceptionThrown(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(a, b));
        }

        [TestCase(8, 2, 3)]
        [TestCase(24.7, 2.5, 3.5)]
        [TestCase(3.389, 1.7, 2.3)]
        [TestCase(0.295, 1.7, -2.3)]
        public void Power_TwoNumbers_AndReturnExp(double exp, double x, double pow)
        {
            double product = uut.Power(x, pow);
            
            Assert.That(product, Is.EqualTo(exp).Within(10E-3));
        }

        [TestCase(1.26, 2, 3)]
        [TestCase(1.299, 2.5, 3.5)]
        [TestCase(1.26, 1.7, 2.3)]
        [TestCase(0.794, 1.7, -2.3)]
        public void Root_TwoNumbers_AndReturnExp(double exp, double x, double root)
        {
            double result = uut.Root(x, root);

            Assert.That(result, Is.EqualTo(exp).Within(10E-3));
        }

        [TestCase(2, 0)]
        [TestCase(-2, 2)]
        [TestCase(-5, 6)]
        public void Root_TwoNumbers_AndReturnExp_ExceptionThrown(double x, double root)
        {
            Assert.Throws<Exception>(() => uut.Root(x, root));
        }
    }
}