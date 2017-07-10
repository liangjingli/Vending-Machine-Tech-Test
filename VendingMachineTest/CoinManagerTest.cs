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
	}
}
