using System;
class Strings_and_Objects
{
    static void Main(string[] args)
    {
        string firstVariable = "Hello";
        string secondVariables = "World";
        object concatenation = firstVariable + " " + secondVariables;
        string casting = (string)concatenation;
        Console.WriteLine(casting);

    }
}

