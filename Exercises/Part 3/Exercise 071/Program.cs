using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      int number = Convert.ToInt32(Console.ReadLine());

        int index = list.FindIndex(a => a == number);
        if (index != -1)
        {
            Console.WriteLine(number + " is at index " + index);
        }

    }
  }
}
