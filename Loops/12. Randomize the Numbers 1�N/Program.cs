using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n =int.Parse(Console.ReadLine());
            Random rand = new Random();
            int sumn=0;
            int i=0;
            int sump=0;
            int[] random = new int[n + 1];
            bool difference = false;
            for (int k = 1; k <=n; k++)
            {
                sumn+=k;
            }
            while (sumn > sump)
            {                
                int number = rand.Next(1, n + 1);
                random[i] = number;
                if (i == 0)
                {
                    difference = true;
                }                
                for (int j = 0; j < i; j++)
                {                   
                    if (random[j] == number)
                    {
                        difference = false;
                        break;
                    }
                    else
                    {
                        difference = true;
                    }
                }
                if (difference)
                {
                    Console.WriteLine(number);
                    sump += number;
                    i++;
                }                
            }

        }
    }




