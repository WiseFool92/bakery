namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberOfDanish { get; set; }
    public int DanishCost { get; set; }

    public Pastry (int numberOfDanish)
    {
      NumberOfDanish = numberOfDanish;
      DanishCost = 2;
    }

    public int GrabDanish()
    {
      return DanishTotalCost();
    }

    // Calculates the cost for pastries
    private int DanishTotalCost()
    {
      int danishTotal = 0;

      if (NumberOfDanish % 3 == 0)
      {
        danishTotal = (NumberOfDanish / 3) * 5;
      }
      else if (NumberOfDanish < 3)
      {
        danishTotal = DanishCost * NumberOfDanish;
      }
      else
      {
        if ((NumberOfDanish - 1) % 3 ==0)
        {
          danishTotal = ((NumberOfDanish - 1) / 3) * 5 + DanishCost;
        }
        else
        {
          danishTotal = ((NumberOfDanish - 1) / 3) * 5 + (DanishCost * 2);
        }
      }
      return danishTotal;
    }
  }
}