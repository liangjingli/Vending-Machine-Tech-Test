using System;
using VendingMachineProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineProjectTest
{
	[TestClass]
	public class CoinTest
	{
		[TestMethod]
		public void CanBeCreatedWithCorrectValue()
		{
			double CoinValue = 50;
			Coin ValidCoin = new Coin(CoinValue);
			Assert.AreEqual(CoinValue, ValidCoin.Value);
		}

		[TestMethod]
		public void RaiseErrorWithInvalidValue()
		{
			double CoinValue = 70;

			try
			{
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