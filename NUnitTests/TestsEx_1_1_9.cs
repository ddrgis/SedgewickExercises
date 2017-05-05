using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_1_1_9;

namespace NUnitTests
{
    [TestFixture]
    public class TestsEx_1_1_9
    {
        [TestCase(5,"101")]
        [TestCase(4, "10")]
        [TestCase(1, "1")]
        public void TestMethod(int input, string result)
        {
            var program = new Program();

            string expected = program.ToBinaryString(5);

            Assert.AreEqual("101", expected);

        }
    }
}
