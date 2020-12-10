using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Give a string:");
    string word = Console.ReadLine();
    string text = "true";
    if(word == text)
                {
                Console.WriteLine("You got it right!");
                }
    else
                {
                Console.WriteLine("Try again!");
            }

    }
  }
}

