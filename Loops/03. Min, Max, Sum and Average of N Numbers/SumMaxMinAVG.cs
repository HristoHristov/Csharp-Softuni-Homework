using System;
//Write a program that reads from the console a sequence of n integer numbers and
//returns the minimal, the maximal number, the sum and the average of all numbers
//(displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) 
//followed by n lines, each holding an integer number. The output is like in the examples below. 9824    ♠ | 9829    ♥ | 9830    ♦
    class SumMaxMinAVG
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            float avg = 0f;
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                sum += c;
                avg += c;
                if(c>max)
                {
                    max = c;
                }
                if(c<min)
                {
                    min = c;
                }
            }
            Console.WriteLine("min= {0}",min);
            Console.WriteLine("max= {0}",max);
            Console.WriteLine("sum= {0}",sum);
            Console.WriteLine("avg= {0:f2}",avg/n);
        }
    }

