using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight:");
            float weight=float.Parse(Console.ReadLine());
            float weightMoon= weight * 0.17f;
            Console.WriteLine("Your weight on the Moon is: {0} ",weightMoon);
        }
    }

