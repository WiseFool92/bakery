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
      int pricePerLoaf = 5;

      if (_numberOfLoaves % 3 == 0)
      {
        _loafCost = (pricePerLoaf * _numberOfLoaves) - ((_loafCost / 3) * pricePerLoaf);
      }
      else if (_loafCost < 3)
      {
        _loafCost = pricePerLoaf * _numberOfLoaves;
      }
      else
      {
        if ((_numberOfLoaves - 1) % 3 == 0)
        {
          _loafCost = (pricePerLoaf * (_numberOfLoaves - 1)) - ((_numberOfLoaves / 3) * pricePerLoaf) + pricePerLoaf;
        }
        else
        {
          _loafCost = (pricePerLoaf * (_numberOfLoaves - 2)) - ((_numberOfLoaves / 3) * pricePerLoaf) + (pricePerLoaf * 2);
        }
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