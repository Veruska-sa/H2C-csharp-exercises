using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = GrEatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    public static int GrEatest(int number1, int number2, int number3) 
    {
              int result;
                if (number1 > number2 && number1 > number3)
                result = number1;

                else if (number2 > number1 && number2 > number3)
                result = number2;

                else
                result = number3;

                return result;
    }


  }
}
