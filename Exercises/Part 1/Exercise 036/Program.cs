using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Give a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if ( num1 == 0 ) 
            {
                break;
            }

            if ( num1 < 0)
            {
                Console.WriteLine("That is negative");
            }

            if (num1 > 0)
            {
                int multiply = num1 * num1;
                Console.WriteLine( multiply );   
            }
        }
    }
  }
}
