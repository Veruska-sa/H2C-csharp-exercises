using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
            int numerator = Convert.ToInt32(Console.ReadLine());
            int denominator = Convert.ToInt32(Console.ReadLine());
            double resultdiv = Division( numerator, denominator);
            Console.WriteLine(resultdiv);
            


    }

    public static double Division(int numerator, int denominator)
    {
        double result = ((double)numerator/(double)denominator);
        return result;
    }

  }
}
