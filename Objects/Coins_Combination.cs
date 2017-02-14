using System;
using System.Collections.Generic;


public class CoinsCombinations
{
  public List<int> Change(int cents)
  {
    List<int> result = new List<int>(){0,0,0,0};
    int pennies = cents % 5;
    result[0] = pennies;
    return result;
  }
}
