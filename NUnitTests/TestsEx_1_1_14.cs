using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class TestsEx_1_1_14
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 2)]
        [TestCase(15, 3)]
        [TestCase(17, 4)]
        public void TestMethod(int input, int expected)
        {
            var result = Ex_1_1_14.cs.Program.Lg(input);

            Assert.AreEqual(expected, result);
        }
    }
}