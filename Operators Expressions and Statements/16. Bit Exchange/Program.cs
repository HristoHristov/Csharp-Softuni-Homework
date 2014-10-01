using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int mask = (q - p);
            if (q > p)
            {

                long right = n >> mask;
                uint left = n << mask;



                for (int i = p; i <= p + k - 1; i++)
                {
                    for (int j = q; j <= q + k - 1; j++)
                    {

                        int onei = 1 << i;
                        int onej = 1 << j;
                        long righto = right & onei;
                        long lefto = left & onej;
                        long leftrig = lefto | righto;
                        int zeroi = ~(1 << i);
                        int zeroj = ~(1 << j);
                        n = (uint)(n & zeroi);
                        n = (uint)(n & zeroj);
                        n = (uint)(n | leftrig);
                    }

                }


                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine(n);


            }
            else
            {
                mask = (p - q);
                long right = n >> mask;
                long left = (n << mask);



                for (int i = p; i <= p + k - 1; i++)
                {

                    for (int j = q; j <= q + k - 1; j++)
                    {

                        int onei = 1 << i;
                        int onej = 1 << j;
                        long righto = right & onej;
                        long lefto = left & onei;
                        long leftrig = lefto | righto;
                        int zeroi = ~(1 << i);
                        int zeroj = ~(1 << j);
                        n = (uint)(n & zeroi);
                        n = (uint)(n & zeroj);
                        n = (uint)(n | leftrig);
                    }

                }

                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine(n);


            }



        }
    }
}
