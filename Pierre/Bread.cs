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
      loafCost = 0;
    }
    public int GetBread()
    {
      LoafCost();
      return _loafCost;
    }

    // Calculates the cost for loaves of bread
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
  }
}