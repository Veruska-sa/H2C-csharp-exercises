using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;

            Console.WriteLine("Write numbers:");
            while (true)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 == -1)
            {
                Console.WriteLine("Thx! Bye!");
                break;
            }
            //Breaks

            if (num1 != -1)
            {
                sum1 = sum1 + num1;
            }
            //Sum of the given numbers
            if  (num1 != -1)
            {
                sum2 = sum2 + 1;
            }
            //How many numbers

            if(num1 % 2 == 0)
            {
                 sum3 = sum3 + 1;
            }
            //How many even

            if(num1 % 2 != 0)
            {
                 sum4 = sum4 + 1;
            }
            //How many odd

            }


            Console.WriteLine("Sum: " + sum1);
            Console.WriteLine("Numbers: " + sum2);
            Console.WriteLine("Average: " + ((double)sum1/sum2));
            Console.WriteLine("Even: " + sum3);
            Console.WriteLine("Odd: " + sum4);

            

    }
  }
}
