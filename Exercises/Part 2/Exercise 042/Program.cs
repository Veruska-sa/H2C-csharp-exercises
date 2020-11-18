using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

                Console.WriteLine("Give an integer");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give second integer");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = num1 + num2;
                double squareRoot = Math.Sqrt(sum);
                Console.WriteLine(squareRoot);
    }
  }
}
