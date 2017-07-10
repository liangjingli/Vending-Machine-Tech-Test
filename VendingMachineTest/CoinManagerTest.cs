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
		public void CoinsCanBeAddedByInsertFunction()
		{
			CoinManager coinManager = new CoinManager();
			List<Coin> UserCoins = coinManager.UserCoins;
			Coin FiftyPence = new Coin(0.50);
			coinManager.Insert(FiftyPence);
			Assert.IsTrue(UserCoins.Contains(FiftyPence));
		}
	}
}
