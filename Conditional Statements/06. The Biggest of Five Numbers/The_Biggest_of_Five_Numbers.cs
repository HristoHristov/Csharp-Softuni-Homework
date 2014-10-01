using System;
//Write a program that finds the biggest of five numbers by using only five if statements.
    class The_Biggest_of_Five_Numbers
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("d= ");
            float d = float.Parse(Console.ReadLine());
            Console.Write("e= ");
            float biggestNimber;
            float e = float.Parse(Console.ReadLine());
            if(a>=b && a>=c && a >=d && a>=e)
            {
                biggestNimber = a;
            }
            else if(b>=a && b>=c && b>=d && b>=e)
            {
                     biggestNimber = b;
            }
               
            else if(c>=a && c>=b && c>=d && c>=e)
            {
                biggestNimber = c;
            }
            
            else if (d>= a && d>=b && d>=c && d>=e)
            {
                biggestNimber = d;
            }
            else
            {
                biggestNimber = e;
            }
           
            
            Console.WriteLine(biggestNimber);
        }
    }

