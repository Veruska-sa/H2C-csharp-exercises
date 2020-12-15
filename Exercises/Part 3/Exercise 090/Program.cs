using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {


        while (true)
        {
        string input = Console.ReadLine();
        if (input == "")
        {
             break;
        }

        string[] parts = input.Split(',');
        int smallest = 0;

        for(int i = 0; i < Convert.ToInt32(parts[1]); i++)
        {
        int number = smallest + Convert.ToInt32(parts[1]);
        if (smallest < number)
        smallest = number;

        {
            Console.WriteLine(smallest);
        }
        }
        }

    }
  }
}



