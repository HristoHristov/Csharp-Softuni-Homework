using System;
class Comparing_Floats
{
    static void Main(string[] args)
    {
        double a = 5.3d;
        double b = 6.01d;
        double eps = 0.000001d;
        bool isEqual = true;
        if (a > b)
        {
            double c = a - b;
            if (c < eps)
            {
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference  " + c + " < eps");
            }
            else
            {
                isEqual = false;
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference of " + c + " is too big (> eps)");
            }
        }
        else if (b > a)
        {
            double c = b - a;
            if (c < eps)
            {
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference " + c + " < eps");
            }
            else
            {
                isEqual = false;
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference of " + c + " is too big (> eps)");
            }
        }
        else
        {
            double c = a - b;
            if (c < eps)
            {
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference " + c + " < eps");
            }
            else
            {
                isEqual = false;
                Console.WriteLine(isEqual);
                Console.WriteLine("The difference of " + c + " is too big (> eps)");
            }

        }




    }
}

