using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int decim = int.Parse(Console.ReadLine());
            string dec = Convert.ToString(decim, 16);
            Console.WriteLine(dec);
        }
    }
}
