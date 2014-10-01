using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Inside_Cercle_outside_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            decimal inputX = decimal.Parse(Console.ReadLine());
            Console.Write("y = ");
            decimal inputY = decimal.Parse(Console.ReadLine());



            decimal x = inputX - 1;
            decimal y = inputY - 1;
            decimal r = 1.5m;


            decimal top = 1;
            decimal left = -1;
            decimal width = 6;
            decimal height = 2;


            bool withinCircle = (x * x) + (y * y) < (r * r);
            bool outOfRect = ((top > x) || (width < x) || (left > y) || (height < y));
            bool result;

            if (withinCircle == true && outOfRect == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
