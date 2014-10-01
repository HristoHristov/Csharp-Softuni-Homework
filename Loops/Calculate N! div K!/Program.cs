using System;
using System.Numerics;
    class Calculate_N__div_K_
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger factn = 1;
            BigInteger factk = 1;            
            for (int i = 1; i <= n; i++)
            {
                factn = factn * i;
                if(k>=i)
                {
                    factk = factk * i;
                }
                

            }
           BigInteger result = factn / factk;
           Console.WriteLine(result);
        }
    }

