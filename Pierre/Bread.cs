namespace Bakery.Pierre
{
  public class Bread
  {
    private int _numberOfLoaves { get; set; }
    private int _loafCost { get; set; }

    public Bread()
    {
      _numberOfLoaves = numberOfLoaves;
      _loafCost = loafCost;
    }
    public int GetBread()
    {
      LoafCost();
      return _loafCost;
    }

    private void LoafCost()
    {
      int loaf = 5;

      if (_numberOfLoaves % 3 == 0)
      {
        _loafCost = (loaf * _numberOfLoaves) - ((_loafCost/3)*loaf);
      }
      else if (_loafCost<3)
      {
        _loafCost = loaf * _numberOfLoaves;
      }
    }













    // public int NumberOfLoaves { get; set; }
    // public int CostPerLoaf { get; set; }
    // public int TotalLoaf { get; set; }

    // public Bread()
    // {
    //   NumberOfLoaves;
    //   CostPerLoaf = 5;
    //   TotalLoaf;
    // }

    // public int CalculateLoaf()
    // {
    //   TotalLoaf = 0;
    //   TotalLoaf = (NumberOfLoaves * CostPerLoaf);
    //   if (NumberOfLoaves == 3)
    //   {
    //     TotalLoaf = 10;
    //   }
    //   return TotalLoaf;
    // }
  }
}