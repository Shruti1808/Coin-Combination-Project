using Nancy;
using Coins;
using System;
using System.Collections.Generic;

namespace Coins
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/results"] = _ =>
      {
        int cents = Request.Query["coin"];
        CoinsCombinations Change = new CoinsCombinations();
        List<int> results = Change.Change(cents);
        return View["results.cshtml", results];
      };
    }
  }
}
