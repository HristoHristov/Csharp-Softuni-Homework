using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberstr =  Console.ReadLine().Split() ;
            Console.WriteLine(numberstr.Length);
            int oddproduct = 1;
            int evenproduct = 1;
            for (int i = 0; i < numberstr.Length; i += 2)
            {
                oddproduct *= int.Parse(numberstr[i]);
                if (i + 1 < numberstr.Length)
                {
                    evenproduct *= int.Parse(numberstr[i + 1]);
                }


            }
            if (oddproduct == evenproduct)
            {
                Console.WriteLine("Yes\nProduct= {0}", evenproduct);
            }
            else
            {
                Console.WriteLine("No\nOdd_product= {0}\neven_product= {1}", oddproduct, evenproduct);
            }
        }
    }
}




