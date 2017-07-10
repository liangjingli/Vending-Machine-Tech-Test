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

		[TestMethod]
		public void RaiseErrorWithInvalidValue()
		{
			try {
				double CoinValue = 0.7;
				Coin InvalidCoin = new Coin(CoinValue);
				Assert.Fail();
			}
			catch (Exception ex)
			{
				Assert.IsTrue(ex is ArgumentException);
			}
		}


	
	}

	
}