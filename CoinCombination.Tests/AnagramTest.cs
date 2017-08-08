using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoinCombination.Models;
using System;

namespace CoinCombination.Tests
{
  [TestClass]
  public class CoinTest
  {
    [TestMethod]
    public void GetCombiantion_CombinationShouldReturnsQuartersOnly_Dictionary()
    {
      //Arrange
      Dictionary<string, int> expected = new Dictionary<string, int>();
      //{"quarters": 2};
      expected["quarter"]=2;
    //Act
      Coin testCoin = new Coin(50);
      Dictionary<string, int> actual = testCoin.GetCombination();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void GetCombiantion_Return2QuartersAnd1Dime_Dictionary()
    {
      //Arrange
      Dictionary<string, int> expected = new Dictionary<string, int>();
      expected["quarter"]=2;
      expected["dime"]=1;
      //{"quarters": 2, "dime": 1};
      //Act
      Coin testCoin = new Coin(60);
      Dictionary<string, int> actual = testCoin.GetCombination();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void GetCombiantion_Return2QuartersAnd1DimeAnd1Nickel_Dictionary()
    {
      //Arrange
      Dictionary<string, int> expected = new Dictionary<string, int>();
      expected["quarter"]=2;
      expected["dime"]=1;
      expected["nickel"]=1;
      //{"quarters": 2, "dime": 1};
      //Act
      Coin testCoin = new Coin(65);
      Dictionary<string, int> actual = testCoin.GetCombination();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void GetCombiantion_Return2QuartersAnd1DimeAnd1Nickel1Penny_Dictionary()
    {
      //Arrange
      Dictionary<string, int> expected = new Dictionary<string, int>();
      expected["quarter"]=2;
      expected["dime"]=1;
      expected["nickel"]=1;
      expected["penny"]=1;
      //{"quarters": 2, "dime": 1};
      //Act
      Coin testCoin = new Coin(66);
      Dictionary<string, int> actual = testCoin.GetCombination();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
