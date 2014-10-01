using System;
//Write a program that, for a given two integer numbers n and x, calculates the sum 
//S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.
class Nfact_div_x_n
{
    static void Main()
    {
        int fact = 1;
        double sum = 1;
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
            sum += fact / Math.Pow(x, i);
        }       
        Console.WriteLine("S= {0:F5}", sum);
    }
}
