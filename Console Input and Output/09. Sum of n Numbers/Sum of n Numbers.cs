using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note that you may need to use a for-loop.
class SumofnNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a \"n\"");
        int n = int.Parse(Console.ReadLine());
        float sum = 0;
        for (int i = 1; i <= n; i++)
        {
            float nsum = float.Parse(Console.ReadLine());
            sum += nsum;

        }
        Console.WriteLine("sum={0}", sum);
    }
}

