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
			vendingMachine.Select("water");
			Coin FiftyPence = new Coin(50);
			vendingMachine.Insert(FiftyPence);
			List<Coin> UserCoins = vendingMachine.VendorCoinManger.UserCoins;
			Assert.IsTrue(UserCoins.Contains(FiftyPence));
		}

		[TestMethod]
		public void FullInegrationTest()
		{
			VendingMachine vendingMachine = new VendingMachine();
			List<Coin> UserCoins = vendingMachine.VendorCoinManger.UserCoins;
			List<Item> ItemList = vendingMachine.Selection;
			vendingMachine.DisplayItems();
			// Will output items in vending machine to console
			vendingMachine.Select("water");
			vendingMachine.Select("water");
			// Adds selections to your selection list
			vendingMachine.Insert(new Coin(50));
			// Prompts for right amount of coins to be inserted for total of your selection
			vendingMachine.Insert(new Coin(50));
			vendingMachine.Insert(new Coin(50));
			// Transaction will end and user will be shown their items and correct change given

			Assert.IsTrue(UserCoins.Count ==  0);
			// Once transaction is done user coins will be reset
			Assert.IsTrue(ItemList.Count == 0);
			// Will also reset user Selection list
		}

	}
}