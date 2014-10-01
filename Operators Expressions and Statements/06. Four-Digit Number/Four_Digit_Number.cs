using System;
class Four_Digit_Number
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        var nToChar = n.ToCharArray();
        int[] fourDigit = Array.ConvertAll(nToChar, c => (int)Char.GetNumericValue(c));
        int sum = fourDigit[0] + fourDigit[1] + fourDigit[2] + fourDigit[3];
        Console.WriteLine("The sum of digits is: {0}", sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", fourDigit[3], fourDigit[2], fourDigit[1], fourDigit[0]);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", fourDigit[3], fourDigit[0], fourDigit[1], fourDigit[2]);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", fourDigit[0], fourDigit[2], fourDigit[1], fourDigit[3]);


    }
}

