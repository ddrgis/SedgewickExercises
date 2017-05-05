using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class TestsEx_1_1_19
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(6)]
        [TestCase(30)]
        public void TestMethod(int input)
        {
            var fibonacci = new Ex_1_1_19.Fibonacci(input);


            long longFibResult  = fibonacci.FibLong(input);
            long fibWithMemResult = fibonacci.FibWithMemo(input);

            Assert.AreEqual(longFibResult, fibWithMemResult);
        }
    }
}