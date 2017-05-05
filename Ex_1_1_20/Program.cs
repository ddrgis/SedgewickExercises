using System;
using System.Collections.Generic;

namespace Ex_1_1_20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 1; i < 1000; i++)
            {
                double result = LnAndFactorialCalculator.Factorial(i);
                Console.WriteLine($"При i = {i} значение = {result}");
            }
            Console.ReadLine();
        }
    }

    public class LnAndFactorialCalculator
    {
        private List<double> _lnValues = new List<double>();
        private List<long> _factValues = new List<long>();

        public static double LnOfNFactorial(int n)
        {
            //double result = 0;

            if (n <= 0)
                throw new ArgumentException();

            return Math.Log(Factorial(n), 2);
        }

        public static double Factorial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            double result;
            checked
            {
                result = n * Factorial(n - 1);
            };

            return result;
        }
    }
}