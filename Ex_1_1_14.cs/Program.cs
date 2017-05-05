using System;

namespace Ex_1_1_14.cs
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public static int Lg(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            var counter = 0;
            for (; n >= 2; counter++)
            {
                n /= 2;
            }
            return counter;
        }
    }
}