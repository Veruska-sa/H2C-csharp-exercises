using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
    
            while (true) 
            {

            Console.WriteLine("Give an integer");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0) 
            {
            Console.WriteLine( number * (-1));
            }

            else
            {
            Console.WriteLine( number );
            }
      
            }
    }
  }
}
