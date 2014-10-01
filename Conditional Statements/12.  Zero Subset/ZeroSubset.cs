﻿using System;
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume 
//that repeating the same subset several times is not a problem.
class ZeroSubset
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split();
        int a = (int.Parse(n[0]));
        int b = (int.Parse(n[1]));
        int c = (int.Parse(n[2]));
        int d = (int.Parse(n[3]));
        int e = (int.Parse(n[4]));
        bool zeroSubset = false;
        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            zeroSubset = true;
        }
        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            zeroSubset = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            zeroSubset = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            zeroSubset = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            zeroSubset = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            zeroSubset = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            zeroSubset = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            zeroSubset = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            zeroSubset = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            zeroSubset = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            zeroSubset = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, b, c);
            zeroSubset = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, b, d);
            zeroSubset = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, b, e);
            zeroSubset = true;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, c, d);
            zeroSubset = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, c, e);
            zeroSubset = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", a, d, e);
            zeroSubset = true;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", b, c, d);
            zeroSubset = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", b, c, e);
            zeroSubset = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", b, d, e);
            zeroSubset = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} = 0", c, d, e);
            zeroSubset = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} = 0", a, b, c, d);
            zeroSubset = true;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} = 0", a, c, d, e);
            zeroSubset = true;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} = 0", a, b, d, e);
            zeroSubset = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} = 0", a, b, c, e);
            zeroSubset = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} = 0", b, c, d, e);
            zeroSubset = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} +{2} + {3} + {4} = 0", a, b, c, d, e);
            zeroSubset = true;
        }
        else
        {
            if (zeroSubset == false)
            {
                Console.WriteLine("no zero subset");
            }
        }

    }
}

