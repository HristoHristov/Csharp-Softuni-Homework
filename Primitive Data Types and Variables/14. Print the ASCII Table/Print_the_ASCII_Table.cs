using System;
class Print_the_ASCII_Table
{
    static void Main()
    {
        char symbol;
        for (int i = 0; i < 256; i++)
        {
            symbol = (char)i;
            if (Char.IsControl(symbol))
            {
                Console.WriteLine("control");
            }
            else
            {
                Console.WriteLine(i + "==>" + symbol);
            }

        }
    }
}

