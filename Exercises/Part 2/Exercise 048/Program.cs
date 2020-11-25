using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            // Write your code here:
	  int sum = 0;
      int count = 0;
      int even = 0;
      int odd = 0;
      Console.WriteLine("Give numbers:");
      while (true)
      {
        int userInput = Convert.ToInt32(Console.ReadLine());
      if (userInput == -1)
       {
        Console.WriteLine("Thx!Bye!");
         break;  
       }
      // stops
       if (userInput != -1)
       {
        sum+= userInput;
        count++;
       }
       // counts sum and numbers
       if (userInput % 2 == 0)
       {
         even = even +1;
       }
       // counts even numbers
        if(userInput % 2 != 0)
       {
         odd = odd +1;
       }
       //counts odd numbers
      double average = (double)sum/double(count);
       // changes the ints to double for average
      }
       Console.WriteLine("Sum: "+sum);
       Console.WriteLine("Numbers: "+count);
       Console.WriteLine("Average: "+average);
       Console.WriteLine("Even: "+even);
       Console.WriteLine("Odd: "+odd);
    }
            

    }
}
  
