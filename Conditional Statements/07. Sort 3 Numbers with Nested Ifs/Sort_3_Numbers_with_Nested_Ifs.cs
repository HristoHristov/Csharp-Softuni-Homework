using System;
//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. 
//Don’t use arrays and the built-in sorting functionality.
    class Sort_3_Numbers_with_Nested_Ifs
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            if (a>=b && a>=c)
            {
                if(b>=c)
                {
                    Console.WriteLine(a+" " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a+ " " + c + " " + b);
                }
            }
            else if(b>=a && b>=c)
            {
                if(a>c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a );
                }

            }
            else  
            {
                if(a>b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }

