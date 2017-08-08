using System;
using System.Collections.Generic;

namespace CoinCombination.Models
{
  public class Coin
  {
    private int _amount;
    private int _quarter;
    private int _dime;
    private int _penny;
    private int _nickel;

    public Coin(int amount)
    {
      _amount = amount;
    }
    public int GetQuarter()
    {
      return _quarter;
    }
    public int GetDime()
    {
      return _dime;
    }
    public int GetNickel()
    {
      return _nickel;
    }
    public int GetPenny()
    {
      return _penny;
    }
    public Dictionary<string,int> GetCombination()
    {
      Dictionary<string, int> coinDictionary = new Dictionary<string, int>();

      if( _amount > 0 )
      {
        _quarter = _amount/25;
        coinDictionary["quarter"] = _quarter;
        coinDictionary["dime"] = 0;
        coinDictionary["nickel"] = 0;
        coinDictionary["penny"] = 0;
        _amount  = _amount % 25;
        if( _amount >= 10 )
        {
          _dime = _amount/10;
          coinDictionary["dime"] = _dime;
          _amount = _amount % 10;
        }
        if( _amount >= 5)
        {
            _nickel = _amount/5;
            coinDictionary["nickel"] = _nickel;
            _amount = _amount % 5;
        }
        if(_amount > 0)
        {
         coinDictionary["penny"] = _amount;
        }
      }
      return  coinDictionary;
    }
  }
}
