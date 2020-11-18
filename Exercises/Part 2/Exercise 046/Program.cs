using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
              Console.WriteLine("Give a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                while (100 >= input)
                {
                Console.WriteLine(input);
                input++;
                }

    }
  }
}
