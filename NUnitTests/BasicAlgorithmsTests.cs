using BasicAlgorithms;
using NUnit.Framework;
using System;

namespace NUnitTests
{
    [TestFixture]
    public class BasicAlgorithmsTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(3, 2, 1)]
        [TestCase(16, 10, 2)]
        [TestCase(10, 16, 2)]
        public void GCD_RightValuesTest(int n1, int n2, int expected)
        {
            int result = BasicAlgoritms.GCD(n1, n2);

            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 1, 1)]
        [TestCase(3, 2, 1)]
        [TestCase(16, 10, 2)]
        [TestCase(10, 16, 2)]
        public void GCDRecursion_RightValuesTest(int n1, int n2, int expected)
        {
            int result = BasicAlgoritms.GCDRecursion(n1, n2);

            Assert.AreEqual(expected, result);
        }


        [TestCase(1, -3)]
        [TestCase(-2, 1)]
        public void GCD_NegativeNumsInput_ExceptionThrow(int n1, int n2)
        {
            Assert.Throws<ArgumentException>(() => BasicAlgoritms.GCDRecursion(n1, n2));
        }

        [TestCase(new[] { 11 }, 1, -1)]
        [TestCase(new[] { 1 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 11, 10)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 11, 10)]
        public void BinarySearch_RigthValuesTest(int[] array, int soughtValue, int expectedIndex)
        {
            int resultIndex = BasicAlgoritms.BinarySearch(array, soughtValue);

            Assert.AreEqual(expectedIndex, resultIndex);
        }

        [TestCase(new[] { 11 }, 0, 0, 666, -1)]
        [TestCase(new[] { 1 }, 0, 0, 1, 0)]
        [TestCase(new[] { 1, 2, 3 }, 0, 2, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 0, 10, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 0, 11, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 0, 10, 11, 10)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 0, 11, 11, 10)]
        public void BinarySearchRecursion_RigthValuesTest(int[] array, int lowIndex, int highIndex, int soughtValue, int expectedIndex)
        {
            int resultIndex = BasicAlgoritms.BinarySearchRecursion(array, lowIndex, highIndex, soughtValue);

            Assert.AreEqual(expectedIndex, resultIndex);
        }
    }
}