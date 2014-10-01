using System;

    class Divide7and5
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            bool withoutRemainder = true;
            if((n % 7 == 0) && (n % 5 ==0))
            {
                Console.WriteLine("Divide by 7 and 5? \n" + withoutRemainder);
            }
            else
            {
                withoutRemainder = false;
                Console.WriteLine("Divide by 7 and 5? \n" + withoutRemainder);
            }
        }
    }
