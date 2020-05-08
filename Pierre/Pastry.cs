namespace Bakery.Pierre
{
  public class Pastry
  {
    public int NumberOfDanish { get; set; }
    public int CostPerDanish { get; set; }
    public int TotalDanish { get; set; }

    public Pastry()
    {
      NumberOfDanish;
      CostPerDanish = 2;
      TotalDanish;
    }
    public int CalculateDanish()
    {
      TotalDanish = 0;
      TotalDanish = (NumberOfDanish * CostPerDanish);
      if (NumberOfDanish == 3)
      {
        TotalDanish;
      }
      return TotalDanish;
    }
  }
}