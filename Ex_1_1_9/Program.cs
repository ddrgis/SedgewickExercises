using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_1_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public string ToBinaryString(int number)
        {
            string result = "";

            while (number > 0)
            {
                int remainder = number % 2;
                number /= 2;
                result += remainder;
            }

            return result;
        }
    }

}
