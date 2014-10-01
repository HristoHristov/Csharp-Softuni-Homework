using System;
    class Third_Digit_is_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int n = number/100;
            int seven = n % 10;
            bool isSeven=true;
            if(seven==7)
               
            {
                Console.WriteLine(isSeven);
            }
            else
            {
                isSeven = false;
                Console.WriteLine(isSeven);
              
            }

            



            
           

         
           
        }
    }

