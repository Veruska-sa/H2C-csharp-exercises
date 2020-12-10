using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
        string userinput = Console.ReadLine();
        string[] pieces = userinput.Split(' ');

            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].Contains("av"))
                    {
                    Console.WriteLine(pieces[i]);
                    }
            }
    }

  }

}

