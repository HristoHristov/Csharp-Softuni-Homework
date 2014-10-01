using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            System.Random random = new Random();
           
            
            for (int i = 0; i <= n; i++)
            {
                int newintstart = random.Next(min, max);
                Console.WriteLine(newintstart);
            }
            

        }
    }
}
