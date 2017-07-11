using System;
using VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemHasName()
        {
			string ItemName = "water";
			double ItemPrice = 50;
			Item water = new Item(ItemName, ItemPrice);
			Assert.AreEqual(ItemName, water.Name);
        }

		[TestMethod]
		public void ItemHasPrice()
		{
			string ItemName = "water";
			double ItemPrice = 50;
			Item water = new Item(ItemName, ItemPrice);
			Console.WriteLine(water.Price);
			Assert.AreEqual(ItemPrice, water.Price);
		}
	}
}
