using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_a_Deck_of_52_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] card = new string[] { "J", "Q", "K", "A" };
           int symbol;
            for (int i = 2; i <= 14; i++)
            {
                for (int j=5; j >= 2; j--)
                {
                    if (j > 2)
                    {
                        symbol = j;
                    }
                    else
                    {
                        symbol = j + 4;
                    }
                    if (i <= 10)
                    {
                        


                        Console.Write("{0,2}", i);
                        Console.Write((char)symbol + " ");
                    }
                    else
                    {
                        switch (i)
                        {
                            case 11:
                                Console.Write("{0,4}",card[0]+(char)symbol+" ");
                                break;
                            case 12:
                                Console.Write("{0,4}",card[1]+ (char)symbol + " ");
                                break;
                            case 13:
                                Console.Write("{0,4}",card[2]+(char)symbol + " ");
                                break;
                            case 14:
                                Console.Write("{0,4}", card[3] + (char)symbol + " ");
                                break;
                            default:
                                break;
                        }
                    }
                    
                }
              
                Console.WriteLine();
                
            }
            

            
        }
    }
}
