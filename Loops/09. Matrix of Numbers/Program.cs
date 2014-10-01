using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int incrementn=n;
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 1+i; j <=incrementn; j++)
                {
                    
                    Console.Write("{0,2}",j);
                                       
                }
                incrementn++;
                Console.WriteLine();
               
            }
        }
    }

