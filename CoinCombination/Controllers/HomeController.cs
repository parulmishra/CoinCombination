using Microsoft.AspNetCore.Mvc;
using CoinCombination.Models;
using System.Collections.Generic;
using System;

namespace CoinCombination.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/Find")]
    public ActionResult Find()
    {
      int amount = int.Parse(Request.Form["amount"]);
      Coin coin = new Coin(amount);
      return View(coin);
    }
  }
}
