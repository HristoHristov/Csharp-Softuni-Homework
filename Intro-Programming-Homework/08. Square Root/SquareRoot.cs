using System;
class SquareRoot
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        double value = Convert.ToInt32(Console.ReadLine());
        double sqrt = Math.Sqrt(value);
        Console.WriteLine("The square root is: {0}", sqrt);
    }
}

