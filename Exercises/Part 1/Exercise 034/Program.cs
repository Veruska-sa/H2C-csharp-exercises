using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
            Start:
                Console.WriteLine("Do you want to continue?");
                string message = Console.ReadLine();

            while(true) {
                if ( message == "no" ) {
                    break;
                }
                if ( message != "no") {
                    goto Start;
                }
            
            }
    }
  }
}
