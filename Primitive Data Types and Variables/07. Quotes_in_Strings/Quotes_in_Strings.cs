using System;
class Quotes_in_Strings
{
    static void Main()
    {
        string variable1 = "The \"use\" of quotations causes difficulties.";
        string variable2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(variable1);
        Console.WriteLine(variable2);

    }
}

