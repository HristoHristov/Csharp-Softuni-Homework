using System;
class Program
{
    static void Main(string[] args)
    {
        string mybirthday = Console.ReadLine();
        DateTime birthday = DateTime.Parse(mybirthday);
        DateTime today = DateTime.Now;
        int age = today.Year - birthday.Year;
        int tenYears = age + 10;

        if (today < birthday.AddYears(age))
        {
            Console.WriteLine(age - 1);
        }
        else
        {
            Console.WriteLine("Your age is: {0}", age);
        }
        Console.WriteLine("Your age after ten Years is: {0}", tenYears);

    }
}

