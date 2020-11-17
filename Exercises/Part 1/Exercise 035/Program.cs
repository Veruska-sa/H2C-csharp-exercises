using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Give a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if ( num1 == 42 ) 
            {
                break;
            }
        }
    }
  }
}
