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

            Assert.That(exp, Is.EqualTo(sum));
        }

        [TestCase(-10, 20, 30)]
        [TestCase(-10, 20.5, 30.5)]
        [TestCase(-0.6, 1.7, 2.3)]
        [TestCase(7.4, -1.9, -9.3)]
        public void Subtract_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double difference = uut.Subtract(a, b);

            Assert.That(exp, Is.EqualTo(difference).Within(1E-15));
        }

        [TestCase(600, 20, 30)]
        [TestCase(625.2, 20.5, 30.5)]
        [TestCase(3.9, 1.7, 2.3)]
        [TestCase(9, -2, -4.5)]
        public void Multiply_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double product = uut.Multiply(a, b);

            Assert.That(exp, Is.EqualTo(product).Within(1E-15));
        }

        [TestCase(0.7, 20, 30)]
        [TestCase(0.7, 20.5, 30.5)]
        [TestCase(0.7, 1.7, 2.3)]
        [TestCase(0.4, -2, -4.5)]
        public void Divide_TwoNumbers_AndReturnExp(double exp, double a, double b)
        {
            double product = uut.Divide(a, b);

            Assert.That(exp, Is.EqualTo(product).Within(1E-15));
        }

        [TestCase(8, 2, 3)]
        [TestCase(24.7, 2.5, 3.5)]
        [TestCase(3.4, 1.7, 2.3)]
        [TestCase(0.3, 1.7, -2.3)]
        public void Power_TwoNumbers_AndReturnExp(double exp, double x, double pow)
        {
            double product = uut.Power(x, pow);
            
            Assert.That(exp, Is.EqualTo(product).Within(10E-15));
        }
    }
}