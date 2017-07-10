using System;
using VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace VendingMachineTest
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
		public void CoinsCanBeAddedByInsertFunction()
		{
			CoinManager coinManager = new CoinManager();
			List<Coin> UserCoins = coinManager.UserCoins;
			Coin FiftyPence = new Coin(0.50);
			coinManager.Insert(FiftyPence);
			Assert.IsTrue(UserCoins.Contains(FiftyPence));
		}

		[TestMethod]
		public void ThrowsErrorWhenInsertedNonValidCoin()
		{
			CoinManager coinManager = new CoinManager();
			Coin NonValidUserCoin = new Coin(0.20);
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
	}
}
