using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (ArgsInNotNull(args) && args[0] == args[1] && args[0] == args[2])
            {
                Console.WriteLine("Равны");
            }
            Console.WriteLine("Не равны");
            Console.ReadLine();
        }

        private static bool ArgsInNotNull(string[] args)
        {
            return args[0] != null && args[1] != null && args[2] != null;
        }
    }
}
