using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
            string user1 = "alex sunshine";
            string[] pieces1 = user1.Split(' ');

            string user2 = "emma haskell";
            string[] pieces2 = user2.Split(' ');

            Console.WriteLine("Enter username:");
            string usernameinput = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string userpasswordinput = Console.ReadLine();

            if(pieces1[0] + pieces1[1] == usernameinput + userpasswordinput)
                {
                Console.WriteLine("You have succesfully logged in!");
                }

            else if(pieces2[0] + pieces2[1] == usernameinput + userpasswordinput)
                {
                Console.WriteLine("You have succesfully logged in!");
                }
            else
                {
                Console.WriteLine("Incorrect username or password!");
                }


    }
  }
}

