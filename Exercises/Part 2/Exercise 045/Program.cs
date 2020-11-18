using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.WriteLine("Give a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int number = 0;
                while (number <= input)
                {
                Console.WriteLine(number);
                number++;
                }
    }
  }
}
