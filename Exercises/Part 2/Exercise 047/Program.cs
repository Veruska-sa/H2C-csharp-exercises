﻿using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      
            Console.WriteLine("Where to?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num2; i <= num1; i++) 
            {
                Console.WriteLine(i);
            }
    }
  }
}
