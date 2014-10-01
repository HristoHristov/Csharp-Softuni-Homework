﻿using System;
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an 
//hour in range [01...12], a minute in range [00...59] and AM / PM designator) and prints “beer time” or “non-beer 
//time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to 
//learn how to parse dates and times.
    class BeerTime
    {
        static void Main()
        {
            //Example: 3:30AM           
            DateTime time = DateTime.Parse(Console.ReadLine());
            int hour = time.Hour;
            string amORpm = time.ToString("tt");
            if((hour>=1 && hour>=12 && amORpm=="PM" ) || (hour<3 && amORpm=="AM"))
            {
               Console.WriteLine("beer time");
               
            }
            else
        	{
                Console.WriteLine("non-beer time");
	        }
            
        }
    }

