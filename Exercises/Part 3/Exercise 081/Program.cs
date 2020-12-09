using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int [] array ={5, 1, 3, 4, 2};
            PrintNeatly(array);

    }

    public static void PrintNeatly(int[] array)
    {
            int row = array.Length; 
            int i = 1;
            foreach (int number in array)
            {
                if (i < row)
                {
                    Console.Write(number + ", ");
                    i++;
                }
                else
                    {
                    Console.Write(number + " ");
                    }
            }

    }
  }
}

