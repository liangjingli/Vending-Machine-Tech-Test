using System;
using VendingMachineProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineProjectTest
{

	[TestClass]
	public class CoinManagerTest
	{
		[TestMethod]
		public void HasListForUserCoins()
		{
			CoinManager coinManager = new CoinManager();
			Assert.IsInstanceOfType(coinManager.UserCoins, typeof(List<Coin>));
		}

		[TestMethod]
		public void HasStockedCoinsOfDifferentValues()
		{
			CoinManager coinManager = new CoinManager();
			Assert.IsInstanceOfType(coinManager.CoinStock, typeof(List<Coin>));
		}

		[TestMethod]
		public void HasListForChangeCoinsToReturn()
		{
			CoinManager coinManager = new CoinManager();
			Assert.IsInstanceOfType(coinManager.CoinsToReturn, typeof(List<Coin>));
		}

		[TestMethod]
		public void CoinsCanBeAddedByInsertFunction()
		{
			CoinManager coinManager = new CoinManager();
			List<Coin> UserCoins = coinManager.UserCoins;
			Coin FiftyPence = new Coin(50);
			coinManager.Insert(FiftyPence);
			Assert.IsTrue(UserCoins.Contains(FiftyPence));
		}

		[TestMethod]
		public void ThrowsErrorWhenInsertedNonValidCoin()
		{
			CoinManager coinManager = new CoinManager();
			Coin NonValidUserCoin = new Coin(20);
			try
			{
				coinManager.Insert(NonValidUserCoin);
				Assert.Fail();
			}
			catch (Exception ex)
			{
				Assert.IsTrue(ex is ArgumentException);
			}
		
		}

		[TestMethod]
		public void CalcualatesCorrectAmountOfCoinsToReturn()
		{
			CoinManager CoinManager1 = new CoinManager();
			CoinManager1.Insert(new Coin(50));
			CoinManager1.Insert(new Coin(50));
			double TotalOfUserCoins = CoinManager1.UserCoins.Sum(coin => coin.Value);
			double PriceOfTotalItems = 60;
			CoinManager1.GiveChange(PriceOfTotalItems);
			double ExpectedChange = TotalOfUserCoins - PriceOfTotalItems;
			double ActualChange = CoinManager1.CoinsToReturn.Sum(coin => coin.Value);
			Assert.AreEqual(ExpectedChange, ActualChange);
		}

		[TestMethod]
		public void AfterGivingChangeAddsUserCoinsToCoinStock()
		{
			CoinManager CoinManager1 = new CoinManager();
			List<Coin> CoinStock = CoinManager1.CoinStock;
			Coin FiftyPence1 = new Coin(50);
			Coin FiftyPence2 = new Coin(50);
			CoinManager1.Insert(FiftyPence1);
			CoinManager1.Insert(FiftyPence2);
			double PriceOfTotalItems = 60;
			CoinManager1.GiveChange(PriceOfTotalItems);
			Assert.IsTrue(CoinStock.Contains(FiftyPence1));
			Assert.IsTrue(CoinStock.Contains(FiftyPence2));
		}

	}
}
