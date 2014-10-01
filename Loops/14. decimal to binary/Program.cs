using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decim = int.Parse(Console.ReadLine());
            string dec1 = Convert.ToString(decim, 2);
            Console.WriteLine(dec1);
        }
    }
}
