using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a width ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter a height ");
        float height = float.Parse(Console.ReadLine());
        float perimeter = width + height + width + height;
        float area = width * height;
        Console.WriteLine("perimeter" + " ==> {0}" + "\n" + "area" + " ==> {1}",perimeter, area);
      

    }
}

