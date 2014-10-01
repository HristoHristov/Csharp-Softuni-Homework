using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("h = ");
            decimal h = decimal.Parse(Console.ReadLine());

            decimal area = (((a + b) / 2) * h);


            Console.WriteLine("Area: {0}", area);
        }

    }
}
