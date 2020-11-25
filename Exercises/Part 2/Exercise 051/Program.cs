using System;

namespace exercise_51
{
  class Program
  {
        public static void Main(string[] args) 
        {
            PrintUntilNumber(5);
        }

        public static void PrintUntilNumber(int number) 
        {
        int laskuri = 1;
        
        do
        {
            Console.WriteLine(laskuri);
            laskuri++;
        }
        while (laskuri <= number);
        }
  }
}
