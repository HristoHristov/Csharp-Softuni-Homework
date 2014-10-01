using System;
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater
//than the second one. As a result print the values a and b, separated by a space.
    class Exchange_If_Greater
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
            else 
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }

