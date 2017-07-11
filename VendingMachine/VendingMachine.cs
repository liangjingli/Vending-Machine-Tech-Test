using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineProject
{

    public class VendingMachine
    {
		public static List<Item> itemStock = new List<Item> { new Item("water", 60),
															  new Item("water", 60),
															  new Item("crisps", 40),
															  new Item("crisps", 40)
		};

		public List<Item> ItemStock { get; private set; }
		public CoinManager CoinManger { get; set; }

		public VendingMachine()
		{
			ItemStock = itemStock;
			CoinManger = new CoinManager();
		}
	}
}
