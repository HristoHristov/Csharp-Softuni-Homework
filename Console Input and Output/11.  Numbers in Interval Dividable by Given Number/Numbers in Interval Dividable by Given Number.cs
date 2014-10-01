using System;
using System.Collections;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
//that the reminder of the division by 5 is 0.
    class NumbersinIntervalDividablebyGivenNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            Console.Write("Start= {0}; End= {1} Comment:",a,b);
            for (int i = a; i <= b;i++ )
            {
                if(i % 5==0)
                {
                    ArrayList ar = new ArrayList();
                    ar.Add(i);
                    int c = ar.Count;
                    count += c;
                    Console.Write(i+" ");                 
                }  
            }
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("p={0}",count);
        }
    }

