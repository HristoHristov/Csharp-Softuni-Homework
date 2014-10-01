using System;
class BooleanVariable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your gender:");
        string gender = Console.ReadLine();
        bool isFemale = false;
        if (gender == "female")
        {
            isFemale = true;
            Console.WriteLine("You are a female");
            Console.WriteLine(isFemale);
        }
        else
        {
            Console.WriteLine("You are a female");
            Console.WriteLine(isFemale + "\n" + "Sorry! You are a male");
        }


    }
}

