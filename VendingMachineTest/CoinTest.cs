using System;
using VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineTest
{
	[TestClass]
	public class CoinTest
	{
		[TestMethod]
		public void CanBeCreatedWithCorrectValue()
		{
			double CoinValue = 0.50;
			Coin ValidCoin = new Coin(CoinValue);
			Assert.AreEqual(CoinValue, ValidCoin.Value);
		}
	}
}