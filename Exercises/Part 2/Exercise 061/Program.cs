using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            //PrintStars(1);
            //PrintSpaces(1);
            //PrintRightTriangle(4);
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
                Console.Write(" ");
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
            int sizeLeft = height - 1;
            int rowStars = 1;
            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(sizeLeft);
                PrintStars(rowStars);
                sizeLeft--;
                rowStars += 2;
            }

            int footSpaces = height - 2;
            for (int x = 0; x < 2; x++)
            {
                PrintSpaces(footSpaces);
                PrintStars(3);
            }
	{

	}

    }
  }
}