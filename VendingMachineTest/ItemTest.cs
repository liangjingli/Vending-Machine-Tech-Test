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
			Item water = new Item("water", 0.50);
			Assert.AreEqual("water", water.Name);
        }

		[TestMethod]
		public void ItemHasPrice()
		{
			Item water = new Item("water", 0.50);
			Console.WriteLine(water.Price);
			Assert.AreEqual(0.50, water.Price);
		}
	}
}
