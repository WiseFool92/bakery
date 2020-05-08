namespace Bakery.Pierre
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public int CostPerLoaf { get; set; }
    public int TotalLoaf { get; set; }

    public Bread()
    {
      NumberOfLoaves;
      CostPerLoaf = 5;
      TotalLoaf;
    }

    public int CalculateLoaf()
    {
      TotalLoaf = 0;
      TotalLoaf = (NumberOfLoaves * CostPerLoaf);
      if (NumberOfLoaves == 3)
      {
        TotalLoaf = 10;
      }
      return TotalLoaf;
    }
  }
}