using System;
using VendingMachineProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineProjectTest
{
	[TestClass]
	public class IntegrationTest
	{
		[TestMethod]
		public void HasItemStock()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Assert.IsInstanceOfType(vendingMachine.ItemStock, typeof(List<Item>));
		}

		[TestMethod]
		public void InsertingCoins()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Coin FiftyPence = new Coin(50);
			vendingMachine.Insert(FiftyPence);
			List<Coin> UserCoins = vendingMachine.VendorCoinManger.UserCoins;
			Assert.IsTrue(UserCoins.Contains(FiftyPence));
		}

	}
}