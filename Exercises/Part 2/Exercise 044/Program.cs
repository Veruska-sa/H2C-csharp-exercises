﻿using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give first integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second integer");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if ( num1 > num2 )
            {
                Console.WriteLine(num1 + " is grEater than " + num2 + ".");
            }

            else if ( num1 < num2 )
            {
                Console.WriteLine(num1 + " is less than " + num2 + ".");
            }

            else if ( num1 == num2 )
            {
                Console.WriteLine(num1 + " is equal to " + num2 + ".");
            }


    }
  }
}
