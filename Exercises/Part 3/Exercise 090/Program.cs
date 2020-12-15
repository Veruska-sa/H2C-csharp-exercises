using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
        int biggestAge = 0;

        while (true)
        {
        string input = Console.ReadLine();
            if (input != "")
            {
             string[] nameAndAge = input.Split(',');

            int age = Convert.ToInt32(nameAndAge[1]);
            if (biggestAge < age)
            {
                biggestAge = age;
            }
            }

                else
                {
                    Console.WriteLine("Age of the oldest: " + biggestAge);
                    break;
                }
            }

        }
  }
}



