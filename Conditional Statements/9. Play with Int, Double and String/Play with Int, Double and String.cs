using System;
//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable
//is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print 
//the result at the console. Use switch statement.
    class Play_with_Int__Double_and_String
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1 -->int\n2 --> double\n3 --> string");
            byte user = byte.Parse(Console.ReadLine());
            switch (user)
            {
                case 1:
                    Console.Write("Please enter a int: ");
                    int a=int.Parse(Console.ReadLine());
                    ++a;
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    ++b;
                    Console.WriteLine(b);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string str =Console.ReadLine();
                    
                    Console.WriteLine(str+"*");
                    break;
                default:
                    break;
            }
        }
    }


