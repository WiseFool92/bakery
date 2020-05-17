namespace Bakery.Models
{
  public class Bread
  {
    // Properties
    public int NumberOfLoaves { get; set; }
    public int LoafCost { get; set; }

    // Constructor
    public Bread (int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
      LoafCost = 5;
    }

    // Seperate method for returning LoafCost()
    public int GrabLoaf()
    {
      return LoafTotalCost();
    }

    // Calculates the cost for loaves of bread
    private int LoafTotalCost()
    {
      int totalLoafCost = 0;

      if (NumberOfLoaves % 3 == 0)
      {
        totalLoafCost = (LoafCost * NumberOfLoaves) - ((NumberOfLoaves / 3) * LoafCost);
      }
      else if (NumberOfLoaves < 3)
      {
        totalLoafCost = LoafCost * NumberOfLoaves;
      }
      else
      {
        if ((NumberOfLoaves - 1) % 3 == 0)
        {
          totalLoafCost = (LoafCost * (NumberOfLoaves - 1)) - ((NumberOfLoaves / 3) * LoafCost) + LoafCost;
        }
        else
        {
          totalLoafCost = (LoafCost * (NumberOfLoaves - 2)) - ((NumberOfLoaves / 3) * LoafCost) + (LoafCost * 2);
        }
      }
      return totalLoafCost;
    }
  }
}