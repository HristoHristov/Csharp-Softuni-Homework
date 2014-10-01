using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int dec = Convert.ToInt32(a,16);
            Console.WriteLine(dec);
        }
    }
}
