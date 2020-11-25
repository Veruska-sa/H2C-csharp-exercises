using System;

namespace exercise_50
{
  class Program
  {
      public static void Main(string[] args)
       {
            Console.WriteLine("How many times?");
            int i = 0;
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (i < userInput)
            {
                PrintPharse();
                i++;
            }
        }

        
        public static void PrintPharse()
    {
        Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
