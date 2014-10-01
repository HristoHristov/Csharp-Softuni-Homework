using System;
class Employee_Data
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first name:");
        string first_name = Console.ReadLine();
        Console.WriteLine("Please enter your Last name:");
        string last_name = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your gender:");
        string gender = Console.ReadLine();
        Console.WriteLine("Please enter your personal id:");
        string personal_id = Console.ReadLine();
        Console.WriteLine("Please enter your employee number:");
        int employeeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(first_name + "\n" + last_name + "\n" + age + "\n" + gender + "\n" + personal_id + "\n" + employeeNumber);
    }
}
