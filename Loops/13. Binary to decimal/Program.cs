using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            int decimal1 = Convert.ToInt32(bin, 2);
            Console.WriteLine(decimal1);
        }
    }
}
