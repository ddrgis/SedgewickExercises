using System;

namespace Ex_1_1_22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            BasicAlgorithms.BasicAlgoritms.BinarySearchRecursion(array, 0, 23, 24);
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}