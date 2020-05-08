namespace Bakery.Pierre
{
  public class Pastry
  {
    // private int _danishCost = 0;
    // private int _numberOfDanish;
    public int _numberOfDanish { get; set; }
    public int _danishCost { get; set; }

    public int GetDanish()
    {
      DanishCost();
      return _danishCost;
    }
    public int SetDanish(int numberOfDanish)
    {
      _numberOfDanish = numberOfDanish;
    }

    // Calculates the cost for pastries
    private void DanishCost()
    {
      int danish = 2;

      if (_numberOfDanish % 3 == 0)
      {
        _danishCost = (_numberOfDanish / 3) * 5;
      }
      else if (_numberOfDanish < 3)
      {
        _danishCost = danish * _numberOfDanish;
      }
      else
      {
        if ((_numberOfDanish - 1) % 3 ==0)
        {
          _danishCost = ((_numberOfDanish - 1) / 3) * 5 + danish;
        }
        else
        {
          _danishCost = ((_numberOfDanish - 1) / 3) * 5 + (danish * 2);
        }
      }
    }
  }
}