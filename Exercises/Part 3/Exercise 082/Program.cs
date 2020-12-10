using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array)
    {
    Console.WriteLine("the elements of the array are: ");
    int index = 0;
    while (index < array.Length)
    {
    int number = array[index];
    int i = 0;
    while (i < number)
    {
    Console.Write("*");
    i++;
    }
    Console.WriteLine("");
    index = index + 1;
    }


  }
        }
    }

