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
            Console.WriteLine("");
            ChristmasTree(4);
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
    {
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < height - i; k++)
                    {
                        PrintSpaces(k);
                    }

                for (int j = 0; j < i * 2+1; j++)
                    {
                        PrintStars(j);
                    }
                Console.WriteLine();
            }

            for (int l = 0; l < 2; l++)
            {
                for (int m = 0; m < height - 2; m++ )
                    {
                    PrintSpaces(m);
                    }
            }

    }
  }
}
