using System;

class ExchangeVariable
{
    static void Main()
    {
        int five = 5;
        int ten = 10;
        five = 10;
        int exchange = 5;
        ten = exchange;
        Console.WriteLine(five + " " + ten);
    }
}

