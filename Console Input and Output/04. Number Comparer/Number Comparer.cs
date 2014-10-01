using System;
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this
//without if statements.
class Number_Comparer
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b= ");
        float b = float.Parse(Console.ReadLine());
        float greater = a > b ? a : b;
        Console.WriteLine("-----------------------------");
        Console.WriteLine(greater);
    }
}
