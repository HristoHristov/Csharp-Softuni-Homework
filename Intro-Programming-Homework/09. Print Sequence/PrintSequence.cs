using System;
class Sequence
{
    static void Main()
    {
        int number;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                number = i;
            }
            else
            {
                number = i * (-1);
            }
            Console.WriteLine(number);
        }
    }
}

