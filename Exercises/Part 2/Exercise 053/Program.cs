using System;

namespace exercise_53
{
  class Program
  { //Main program
    public static void Main(String[] args)
    {
            int numerator = Convert.ToInt32(Console.ReadLine());
            int denominator = Convert.ToInt32(Console.ReadLine());
            Division(numerator, denominator);
    }

        //Method
    public static void Division(int numerator, int denominator)
    {
            double result = ((double)numerator/(double)denominator);
            Console.WriteLine(result);
    }

  }
}