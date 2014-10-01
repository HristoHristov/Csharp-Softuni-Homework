using System;
class ProgramNull_Values_Arithmetic
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine(i);
        Console.WriteLine(d);
        i += 22;
        d += 222;
        Console.WriteLine(i);
        Console.WriteLine(d);
        i = 22;
        d = 222;
        Console.WriteLine(i);
        Console.WriteLine(d);


    }
}
