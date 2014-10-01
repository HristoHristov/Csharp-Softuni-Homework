using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the 
//decimal point.
    class CirclePerimeterandArea
    {
        static void Main()
        {
            Console.Write("r= ");
            float r=float.Parse(Console.ReadLine());
            float p=3.14159f ;
            Console.WriteLine("perimeter: c=? \nc=2*{0}*{1}\nc={2:F2}",p,r,2*p*r);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Area: A=?\nA={0}*{1}*{1}\nA={2:F2}",p,r,p*Math.Pow(r,2));
        }
    }

