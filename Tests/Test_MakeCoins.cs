using Xunit;
using System;
using System.Collections.Generic;

namespace Coins
{
  public class CoinsCombinationsTest
  {
    [Fact]
    public void CoinsCombinations_ForInputSmallerThan5_pennies()
    {
      List<int> expectedResult = new List<int>(){3,0,0,0};
      CoinsCombinations testChange = new CoinsCombinations();
      Assert.Equal(expectedResult, testChange.Change(3));
    }
    [Fact]
    public void CoinsCombinations_ForInputGreaterThanEqualTo5SmallerThan10_nickels()
    {
      List<int> expectedResult = new List<int>(){3,1,0,0};
      CoinsCombinations testChange = new CoinsCombinations();
      Assert.Equal(expectedResult, testChange.Change(8));
    }
  }
}
