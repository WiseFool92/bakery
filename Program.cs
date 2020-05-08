using System;
using Bakery;
using Bakery.Pierre;
//using Console = Colorful.Console;

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
      Console.WriteLine("Welcome to Pierre's, home of grandma's baked goods. ");
      Console.WriteLine("Our favorites are: Artisanal bread loaves & danishes!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.DarkRed;
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
        Console.WriteLine("That's too bad, I suppose you could try Larry's Bagel Bruiser's down the road!");
      }
    }
    public static void TakeOrder()
    {
      int loafAmt = 0;
      int danishAmt = 0;

      Console.WriteLine("Our hostess will now take your order!");
      Console.WriteLine("How many artisanal loaves would you like to purchase?");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

      string loaf = Console.ReadLine();
      bool loafParse = int.TryParse(loaf, out loafAmt);

      Console.WriteLine("How many artisanal danish's would you like to purchase?");

      string danish = Console.ReadLine();
      bool danishParse = int.TryParse(danish, out danishAmt);

      if (loafParse && danishParse && loafAmt >= 0 && danishAmt >= 0)
      {
        Bread customerLoaf = new Bread();
        customerLoaf.SetLoaf(loafAmt);
        Pastry customerDanish = new Pastry();
        customerDanish.SetDanish(danishAmt);

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Thank you for giving Pierre's Bakery your buisness. Your Total is: $"+(customerDanish.GetDanish()+customerLoaf.GetLoaf()));
      }
      else
      {
        Console.WriteLine("Sorry, you can only purchase whole loaves & danishes!");
      } 
    }
  }
}