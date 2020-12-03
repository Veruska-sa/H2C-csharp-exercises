using System;
using System.Collections.Generic;

namespace exercise_69
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
      Print(list);
    }

    public static void Print(List<int> list)
    {
        foreach (int value in list)
        {
            Console.WriteLine()
        }
    }

    }
  }

