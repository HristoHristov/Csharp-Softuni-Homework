using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Extract_Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int b = int.Parse(Console.ReadLine());

            int mask = 1 << b;
            int addMask = i & mask;

            Console.WriteLine("Bit @ p: " + ((addMask != 0) ? "1" : "0").ToString());
        }
    }
}
