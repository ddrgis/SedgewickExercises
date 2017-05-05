using System;
using System.Diagnostics;
using System.Globalization;

namespace Ex_1_1_19
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var depth = 40;
            var fibonacci = new Fibonacci(depth);
            var elapsedTimes = new string[depth];
            for (var i = 0; i < depth; i++)
            {
                sw.Start();
                double result = fibonacci.FibLong(i);
                //double result = fibonacci.FibWithMemo(i);
                sw.Stop();
                double elapsedTime = sw.Elapsed.TotalSeconds;
                elapsedTimes[i] = elapsedTime.ToString(CultureInfo.CurrentCulture);
                Console.WriteLine($"При i = {i} време выполнения F({i}) = {elapsedTime}\nРезультат = {result}\n");
            }
            Console.WriteLine(string.Join("\n", elapsedTimes));
            Console.ReadLine();
        }
    }

    public class Fibonacci
    {
        private readonly long[] _results;

        public Fibonacci(int depth)
        {
            _results = new long[depth + 1];
        }

        public long FibWithMemo(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            if (_results[n] != 0)
                return _results[n];

            long result = FibWithMemo(n - 1) + FibWithMemo(n - 2);
            _results[n] = result;
            return result;
        }

        public long FibLong(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return FibLong(n - 1) + FibLong(n - 2);
        }
    }
}