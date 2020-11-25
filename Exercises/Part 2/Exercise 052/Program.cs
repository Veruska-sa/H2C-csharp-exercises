using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      
            int num = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(num);
    }

    public static void PrintFromNumberToOne(int number)
        {
       int laskuri = 1;
        
        do
        {
            Console.WriteLine(number);
            number--;
        }
        while (laskuri <= number);
        }

  }
}
