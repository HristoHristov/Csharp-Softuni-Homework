using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their 
//sum. 
class Sumof5Numbers
{
    static void Main()
    {
        Console.Write("numbers= ");
        string[] n = Console.ReadLine().Split();
        int sum = 0;
        foreach (string b in n)
        {
            int number = int.Parse(b);
            sum += number;
        }
        Console.WriteLine("sum= {0}", sum);
    }
}

