using System;
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a
//sequence of if operators. 
class Multiplication_Sign
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result: -");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result: +");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (a < 0 && b < 0)
                {
                    Console.WriteLine("Result: +");
                }
                else if(b<0 && c<0)
                {
                    Console.WriteLine("Result: +");
                }
                else
                {
                    Console.WriteLine("-");
                }
                
            }
            

            
        }
    }

