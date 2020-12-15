using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give name, age (empty line exits):");
 
        int oldest = 0;
        string oldestName = "";
        while (true)
        {
            string input = Console.ReadLine();
 
        if (input != "")
           {
        string[]nameAndAge = input.Split(',');
        int age = Convert.ToInt32(nameAndAge[1]);
 
        if (age > oldest)
        {
        oldest = age;
        oldestName = nameAndAge[0];
        }
 
        }
        else
        {
        Console.WriteLine("Name of the oldest: " +oldestName);
        break;
        }
 
 }
 }
 } 
}


