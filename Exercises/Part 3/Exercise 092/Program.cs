using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
            int highest = 0;
            int longest = 0;
            string longestName = "";
            while (true)
                {
                string input = Console.ReadLine();
                if (input != "")
                    {
                    string [] nameAndAge = input.Split(',');
                    int year = Convert.ToInt32(nameAndAge[1]);
                    int nameSize = nameAndAge[0].Length;
                    int age = 2020 -(year);

                    if (age > highest) highest = age;

                        if (nameSize > longest)
                        {
                        longest = nameSize;
                        longestName = nameAndAge[0];
                        }
                }

                else
                {
                    Console.WriteLine("Longest name: " + longestName);
                    Console.WriteLine("Highest age: " + highest);
                    break;
                }
            }

    }
  }
}



