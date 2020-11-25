using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:

        Console.WriteLine("How many times?");
        int userInput = Convert.ToInt32(Console.ReadLine());
    }

    // Write your method here:
    public static void PrintPharse(int numOfTimes) 
{
    int i = 0;
    while (i < numOfTimes) 
    {
      PrintPharse;
      i++;
    }
}

    public static void PrintPharse()
    {
       Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
