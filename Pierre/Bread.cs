namespace Bakery.Pierre
{
  public class Bread
  {
    public int _numberOfLoaves { get; set; }
    public int _loafCost { get; set; }

    public int GetLoaf()
    {
      LoafCost();
      return _loafCost;
    }
    public void SetLoaf(int numberOfLoaves)
    {
      _numberOfLoaves = numberOfLoaves;
    }

    // Calculates the cost for loaves of bread
    private void LoafCost()
    {
      int pricePerLoaf = 5;

      if (_numberOfLoaves % 3 == 0)
      {
        _loafCost = (pricePerLoaf * _numberOfLoaves) - ((_numberOfLoaves / 3) * pricePerLoaf);
      }
      else if (_numberOfLoaves < 3)
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