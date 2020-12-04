using System;

namespace exercise_61
{
  class Program
  {
     public static void Main(String[] args)
     {
        int korkeus = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= korkeus; i++) // looppi riveille
            {
                for (int j=0; j<(korkeus-i); j++) // tyhjiä
                {
                Console.Write(" ");
                }
                    for (int k = 0; k < (i*2)-1; k++) // tahtiä
                    {
                    Console.Write("*");
                    }
             Console.WriteLine(""); // rivin vaihto

            }


     }

    }
  }