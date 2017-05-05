using System;
using Ex_1_1_20;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class TestsEx_1_1_20
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void Factorial_RightBehaviorTest(int input, double expected)
        {
            double result = LnAndFactorialCalculator.Factorial(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 2.58)]
        [TestCase(4, 4.58)]
        public void LnOfNFactorial_RightBehaviorTest(int input, double expected)
        {
            double result = LnAndFactorialCalculator.LnOfNFactorial(input);

            Assert.AreEqual(expected, result, delta: 0.1);
        }
    }
}