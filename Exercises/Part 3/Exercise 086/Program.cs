using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a string");
            string userstring = Console.ReadLine();
            string[] pieces = userstring.Split(' ');

            for (int i = 0; i < pieces.Length; i++)
            {
            Console.WriteLine(pieces[i]);
            }


    }
  }
}

