using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Check_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int b = int.Parse(Console.ReadLine());

            int mask = 1 << b;
            int addMask = n & mask;

            bool bitValue = (addMask != 0);

            string binaryNumber = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("Binary n: {0}\nBit @ p: {1}", binaryNumber, bitValue);
        }
    }
}
