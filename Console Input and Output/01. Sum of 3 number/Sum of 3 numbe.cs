using System;
//Write a program that reads 3 real numbers from the console and prints their sum. Examples:
class Sum_of_3_Numbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}

