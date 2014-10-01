using System;
class LongSequence
{
    static void Main(string[] args)
    {
        int number;
        for (int i = 2; i < 1000; i++)
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

