using System;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at 
//a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, .... Note that you may need to learn 
//how to use loops.
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int F = 1;
        Console.Write("Fibonacci numbers: {0},{1}", a, b);
        for (int i = 0; i < n - 2; i++)
        {
            F = a + b;
            a = b;
            b = F;
            Console.Write(",{0}", F);
        }
    }
}


