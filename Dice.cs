using System.Numerics;

class Dice
{
  private Random _random;
  private const int MinValue = 1;
  private int MaxValue = 6;
  public Dice(int maxValue = 6)
  {
    if (maxValue != MaxValue)
    {
      MaxValue = maxValue;
    }
    _random = new Random();
  }

  public int Roll()
  {
    return _random.Next(MinValue, MaxValue + 1); // Returns a number between 1 and 6
  }
}