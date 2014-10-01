using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints
//its real roots).
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            double sqrt = Math.Sqrt(D);
            double division = 2 * a;
            double x2 = (-b) + sqrt;
            double resultx2 = x2 / division;         
            double x1 = -(b) - sqrt;
            double resultx1 = x1 / division;
            Console.WriteLine("------------------------------------");
            if (D < 0)
            {
                Console.WriteLine("no real root");
            }
            else
            {
                Console.WriteLine("X1= {0}; X2={1}",resultx1,resultx2);
            }
        }
    }
