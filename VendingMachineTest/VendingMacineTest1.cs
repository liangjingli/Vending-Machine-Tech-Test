using System;
using VendingMachineProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace VendingMachineProjectTest
{
	[TestClass]
	public class VendingMachineTest
	{
		[TestMethod]
		public void HasItemStock()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Assert.IsInstanceOfType(vendingMachine.ItemStock, typeof(List<Item>));
		}

	}
}