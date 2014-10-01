using System;
class Point_in_a_Circle
{
    static void Main(string[] args)
    {
        Console.Write("Enter a \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a \"y\": ");
        double y = Double.Parse(Console.ReadLine());
        int Kx = 0;
        int Ky = 0;
        bool isInside = true;
        double inside = Math.Pow(x - Kx, 2) + Math.Pow(y - Ky, 2);
        double R = Math.Pow(2, 2);
        if (inside <= R)
        {
            Console.WriteLine(isInside);
        }
        else
        {
            isInside = false;
            Console.WriteLine(isInside);
        }
    }
}

