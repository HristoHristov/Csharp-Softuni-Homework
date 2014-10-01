using System;
class Program
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());      
            int k=int.Parse(Console.ReadLine());
            int resultn = 1;
            int resultk = 1;
            for (int i = n; i > n - k;i--)
			{
                resultn = resultn * i;

            }
                //Console.WriteLine(i);
            for (int j = 1; j <= k; j++)
            {
                resultk = resultk * j;
            }
            Console.WriteLine(resultn);
            int result = resultn / resultk;
            Console.WriteLine(result);

        }
    }
