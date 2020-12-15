using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("How many days? ");
     int  num1 = Convert.ToInt32(Console.ReadLine());
     int result = num1* 24 * 60 * 60;
     Console.WriteLine( result );

    }
  }
}
