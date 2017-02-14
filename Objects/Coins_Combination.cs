using System;
using System.Collections.Generic;


public class CoinsCombinations
{
  public List<int> Change(int cents)
  {
    List<int> result = new List<int>(){0,0,0,0};
    int quarters = cents/25;
    int dimes = (cents%25)/10;
    int nickels = ((cents%25)%10)/5;
    int pennies = cents % 5;
    result[0] = pennies;
    result[1] = nickels;
    result[2] = dimes;
    result[3] = quarters;
    return result;

  }

}
