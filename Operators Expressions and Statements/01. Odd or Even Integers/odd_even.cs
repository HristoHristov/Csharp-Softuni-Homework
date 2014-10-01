using System;
class odd_even
{
    static void Main()
    {

        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine(" Odd? \n false");
        }
        else
        {
            Console.WriteLine(" Odd? \n true");
        }

    }
}