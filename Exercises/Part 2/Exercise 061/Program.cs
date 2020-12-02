using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            PrintStars(1);
            PrintSpaces(1);
            PrintRightTriangle(4);
    }

    public static void PrintStars(int number)
    {
            int i = 0;

            while (i < number)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
            int i = 0;

            while (i < number)
            {
                Console.Write("");
                i++;
            }
    }

    public static void PrintRightTriangle(int size)
    {
            for (int i = 1; i <=size; i++)
            {
                PrintSpaces(size-i);
                PrintStars(i);
            }
    }

    public static void ChristmasTree(int height)
    //{

    //}
  }
}
