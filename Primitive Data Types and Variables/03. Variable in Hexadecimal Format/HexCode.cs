using System;

class HexCode
{
    static void Main()
    {
        string hex = "0Xfe";
        int hexcode = Convert.ToInt32(hex, 16);
        Console.WriteLine("values: Hexcode: result:");
        Console.WriteLine(254 + "\t" + hex + "\t " + hexcode);
    }
}

