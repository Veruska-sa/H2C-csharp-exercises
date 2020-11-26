using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
        int answer = Smallest(2, 7);
        Console.WriteLine("Smallest: " + answer);
    }

    public static int Smallest(int number1, int number2) 
    {
              int result;
                if (number1 < number2)
                result = number1;
                else
                result = number2;

                return result;

    }
    
  }
}
