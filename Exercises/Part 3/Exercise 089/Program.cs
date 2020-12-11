using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
            string userstring = Console.ReadLine();
            string[] pieces = userstring.Split(' ');
            int pituus = pieces.Length;
            Console.WriteLine(pieces[pituus-1]);

        }
    }
  }




