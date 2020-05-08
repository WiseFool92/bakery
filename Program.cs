using System;
//using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Welcome();
      TakeOrder();
    }
    public static void Welcome()
    {
      bool participate = false;
      Console.WriteLine("Welcome to Pierre's, home of grandma's baked goods. Our current favorites are our breads & pastries!");
      Console.WriteLine("Would you like to know our pricing & specials?");
      string response = (Console.ReadLine().ToLower());
      if (response == "yes")
      {
        participate = true;
        Console.WriteLine("Pierre's is at your service!");
        Console.WriteLine("Bread: $5 each Or three for $10");
        Console.WriteLine("Pastries: $2 each Or three for $5");
      }
      else
      {
        participate = false;
        Console.WriteLine("That's too bad, I suppose you could try Larry's Bagel Bruiser's down the road!");
      }
    }
    public static void TakeOrder()
    {
      Console.WriteLine("What would you like to purchase today?");

    }
  }
}