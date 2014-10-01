using System;
//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a
//program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
    class Program
    {
        static void Main()
        {
            Console.Write("Character= ");
            string character =Console.ReadLine();
            int number;
            if (int.TryParse(character,out number))
            {
                  if (number > 1 && number <= 10)
                  {
                    Console.WriteLine("Valid card sign?\nyes");
                  }
                  else
                  {
                      Console.WriteLine("Valid card sign?\nno");
                  }
            }
            else if(character=="A" || character=="K" || character=="J" || character=="Q" )
            {
                Console.WriteLine("Valid card sign?\nyes");
            }
            else
            {
                Console.WriteLine("Valid card sign?\nno");
            }
            
        } 
     }

