using System;

namespace Ex_1_1_24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int result = BasicAlgorithms.BasicAlgoritms.GCDRecursionTraced(105, 24);
            Console.WriteLine($"Done, result = {result}");
            Console.WriteLine();
            result = BasicAlgorithms.BasicAlgoritms.GCDRecursionTraced(1111111, 1234567);
            Console.WriteLine($"Done, result = {result}");
            Console.Read();
        }
    }
}