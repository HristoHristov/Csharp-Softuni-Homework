using System;
//Write a program that converts a number in the range [0...999] to words, corresponding to the English
//pronunciation.
    class Program
    {
        static void Main()
        {
            Console.Write("number= ");
            int numbers = int.Parse(Console.ReadLine());
            int hundred = numbers / 100;
            int one = numbers % 10;
            int ten = (numbers % 100 - numbers % 10) / 10;
            int elevenTOtwenty = numbers % 100;
            Console.Write("number as word: ");
            if(hundred==0 && ten==0 && one==0)
            {
                Console.WriteLine("zero");
            }
            if (hundred >= 1)
            {
                switch (hundred)
                {
                    case 1:
                        Console.Write("one hundred");
                        break;
                    case 2:
                        Console.Write("two hundred");
                        break;
                    case 3:
                        Console.Write("Three hundred");
                        break;
                    case 4:
                        Console.Write("four hundred");
                        break;
                    case 5:
                        Console.Write("five hundred");
                        break;
                    case 6:
                        Console.Write("six hundred");
                        break;
                    case 7:
                        Console.Write("seven hundred");
                        break;
                    case 8:
                        Console.Write("eight hundred");
                        break;
                    case 9:
                        Console.Write("nine hundred");
                        break;
                    default:
                        Console.Write("Not a digit");
                        break;
                }
            }
            if (ten >= 2)
            {
                if (hundred > 0)
                {
                    Console.Write(" and ");
                }
                switch (ten)
                {

                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;                   
                }
            }
            if (one >= 0 && (ten == 0 || ten >= 2))
            {
                if (ten == 0 && numbers>9 )
                {
                    Console.Write(" and ");
                }
                switch (one)
                {                    
                    case 1:
                        Console.Write("one\n");
                        break;
                    case 2:
                        Console.Write("two\n");
                        break;
                    case 3:
                        Console.Write("three\n");
                        break;
                    case 4:
                        Console.Write("four\n");
                        break;
                    case 5:
                        Console.Write("five\n");
                        break;
                    case 6:
                        Console.Write("six\n");
                        break;
                    case 7:
                        Console.Write("seven\n");
                        break;
                    case 8:
                        Console.Write("eight\n");
                        break;
                    case 9:
                        Console.Write("nine\n");
                        break;                    
                }
            }
            if (elevenTOtwenty >= 10 && elevenTOtwenty <= 19)
            {
                if (hundred > 0)
                {
                    Console.Write(" and ");
                }
                switch (elevenTOtwenty)
                {

                    case 10:
                        Console.Write("ten ");
                        break;
                    case 11:
                        Console.Write("eleven ");
                        break;
                    case 12:
                        Console.Write("twelve ");
                        break;
                    case 13:
                        Console.Write("thirteen ");
                        break;
                    case 14:
                        Console.Write("fourteen ");
                        break;
                    case 15:
                        Console.Write("fifteen ");
                        break;
                    case 16:
                        Console.Write("sixteen ");
                        break;
                    case 17:
                        Console.Write("seventeen ");
                        break;
                    case 18:
                        Console.Write("eighteen ");
                        break;
                    case 19:
                        Console.Write("nineteen ");
                        break;                    
                }
            }       
        }
    }

