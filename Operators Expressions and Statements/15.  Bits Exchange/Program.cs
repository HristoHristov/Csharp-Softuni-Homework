using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Bit_exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = 21;
            long left = (n << p);
            long right = (n >> p);
            long beforres1 = (1 << 24);
            long beforres2 = (1 << 25);
            long beforres3 = (1 << 26);
            long beforres4 = (1 << 3);
            long beforres5 = (1 << 4);
            long beforres6 = (1 << 5);
            long result0 = (beforres1 | beforres2 | beforres3 | beforres4 | beforres5 | beforres6);
            long a = ~(1 << 24);
            long b = ~(1 << 25);
            long c = ~(1 << 26);
            long d = ~(1 << 3);
            long e = ~(1 << 4);
            long f = ~(1 << 5);
            long result1 = (a & b & c & d & e & f);
            long resultn = (n & result1);
            long resleft = (result0 & left);
            long resright = (result0 & right);
            long resultLeftandRight = (resleft | resright);
            long endresult = (resultn | resultLeftandRight);
            Console.WriteLine(Convert.ToString(endresult, 2).PadLeft(32, '0'));
            Console.WriteLine("11111001111111110000000000111111");

        }
    }
}
