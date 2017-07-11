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
		public CoinManager VendorCoinManger { get; set; }

		public VendingMachine()
		{
			ItemStock = itemStock;
			VendorCoinManger = new CoinManager();
		}

		public void Insert(Coin coin)
		{
			VendorCoinManger.Insert(coin);
			double PoundFormat = coin.Value / 100;
			Console.WriteLine("You Have Inserted £{0:0.00}", PoundFormat);
		}
	}
}