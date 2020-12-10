using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;
      bool found = false;

      Console.WriteLine("Search for?");
      int search = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < array.Length; i++)
        { 
            if (array[i] == search)
            {
                found = true;
                Console.WriteLine(search + " is at index " + i);
            }
                

        }
            if (found == false)
            {
            Console.WriteLine(search + " was not found.");
            }

    }

  }
}


