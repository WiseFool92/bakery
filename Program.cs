using System;
using Bakery.Models;

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

      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Welcome to Pierre's, home of grandma's baked goods!");
      Console.WriteLine("Our favorites are: Artisanal Bread Loaves & Danishes!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Would you like to know our pricing & specials?");

      string response = (Console.ReadLine().ToLower());
      if (response == "yes")
      {
        participate = true;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Pierre's is at your service!");
        Console.WriteLine("Bread loaves are: $5 each Or three for $10");
        Console.WriteLine("Danish's are: $2 each Or three for $5");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      }
      else
      {
        participate = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("That's too bad dear Grandma Pierre said with a sickeningly cheerful smile. You hear deadbolts slide and click into place. Suddenly realizing that behind you are Larry's Bagel Bruiser's who have filled the small quaint rustic room! Thinking better of it you decide to make a small purchase. After all the specials are spectacular!");
      }
    }
    public static void TakeOrder()
    {
      int loafAmt = 0;
      int danishAmt = 0;

      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Our hostess will now take your order!");
      Console.WriteLine("How many artisanal loaves would you like to purchase?");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

      string loaf = Console.ReadLine();
      bool loafParse = int.TryParse(loaf, out loafAmt);

      Console.WriteLine("How many artisanal danish's would you like to purchase?");

      string danish = Console.ReadLine();
      bool danishParse = int.TryParse(danish, out danishAmt);

      if (loafParse && danishParse && loafAmt >= 0 && danishAmt >= 0)
      {
        Bread customerLoaf = new Bread(loafAmt);
        Pastry customerDanish = new Pastry(danishAmt);

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Thank you for giving Pierre's Bakery your buisness. Your Total is: $"+(customerDanish.GrabDanish()+customerLoaf.GrabLoaf()));

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Sorry, you can only purchase whole loaves & danishes!");
      } 
    }
  }
}