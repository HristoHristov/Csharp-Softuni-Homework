using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger multiplication_n = 1;
            BigInteger multiplication_i = 1;
            for(int i=2; i<=n;i++)
            {
                multiplication_n *= n + i;
                multiplication_i *= i;
            }
            Console.WriteLine("Catalan n= {0}", multiplication_n / multiplication_i);
        }
    }
}
