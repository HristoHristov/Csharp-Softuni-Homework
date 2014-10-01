using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bitwise_Extract_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int moveRight = inputNumber >> 3;
            int bit = moveRight & 1;

            Console.WriteLine("Bit 3# is " + bit);
        }
    }
}
