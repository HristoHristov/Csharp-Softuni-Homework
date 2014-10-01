using System;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name,
//last name, age and a phone number. Write a program that reads the information about a company and its manager 
//and prints it back on the console.
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter a name of company: ");
        string CompanyName = Console.ReadLine();
        Console.Write("Enter a address of company: ");
        string CompanyAdderess = Console.ReadLine();
        Console.Write("Enter a phone number of company: ");
        string phoneCompany = Console.ReadLine();
        Console.Write("Enter a fax number of company: ");
        string fax = Console.ReadLine();
        int faxnumber;
        Console.Write("Enter a web site of company: ");
        string website = Console.ReadLine();
        Console.Write("Enter a first name of manager: ");
        string firstname = Console.ReadLine();
        Console.Write("Enter a last name of manager: ");
        string Lastname = Console.ReadLine();
        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerphone = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("{0,-15}", CompanyName);
        Console.WriteLine("Address: {0}", CompanyAdderess);
        Console.WriteLine("Tel: {0}", phoneCompany);
        if (int.TryParse(fax, out faxnumber))
        {
            Console.WriteLine("Fax: {0}", faxnumber);
        }
        else
        {
            Console.WriteLine("Fax: (No Fax)");
        }
        Console.WriteLine("web site: {0}", website);
        Console.WriteLine("Manager:  {0}" + ' ' + " {1} (age: {2}, tel: {3})", firstname, Lastname, age, managerphone);   
    }
}

