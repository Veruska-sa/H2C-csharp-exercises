﻿using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

            int sum1 = 0;
            int sum2 = 0;
    
            while (true) 
            {

            Console.WriteLine("Give a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0) 
            {
                break;
            }
            // 0 Breaks
            if  (number != 0)
            {
            sum1 = sum1 + 1;
            }
            //increases amount
            if  (number != 0)
            {
            sum2 = sum2 + number;
            }
            //counts total sum
            }
            Console.WriteLine("Total sum of numbers: " + sum2);
            Console.WriteLine("Total amount of numbers: " + sum1);
            }
    }
  }
