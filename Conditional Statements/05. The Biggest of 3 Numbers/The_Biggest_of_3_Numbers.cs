using System;
//Write a program that finds the biggest of three numbers.
    class The_Biggest_of_3_Numbers
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            if(a>=b && a>=c)
            {
                Console.WriteLine(a);
            }
            else if(b>c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }

