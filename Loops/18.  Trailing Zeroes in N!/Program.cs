using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.Trailing_Zeroes_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger p = 10;
            bool isZero = true;
            BigInteger fact = 1;
            BigInteger result = 0;
            BigInteger count = 0;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            


            while (isZero)
            {
                result = fact % p;
                if (result == 0)
                {
                    count += 1;
                }
                else
                {
                    isZero = false;
                }
                p = p * 10;
            }
            Console.WriteLine(count);

        }
    }
}
