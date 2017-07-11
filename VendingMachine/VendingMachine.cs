using System;
using System.Collections.Generic;
using System.Linq;
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
		public List<Item> Selection { get; private set; }
		public CoinManager VendorCoinManger { get; set; }

		public VendingMachine()
		{
			ItemStock = itemStock;
			Selection = new List<Item>();
			VendorCoinManger = new CoinManager();
		}

		public void Insert(Coin coin)
		{
			VendorCoinManger.Insert(coin);
			double PoundFormat = coin.Value / 100;
			double UserCoinsTotal = TotalOfUserCoins(VendorCoinManger.UserCoins) / 100;
			Console.WriteLine("You Have Inserted £{0:0.00}", PoundFormat);
			Console.WriteLine("Your Total £{0:0.00}", UserCoinsTotal);
		}

		public void DisplayItems()
		{
			Console.WriteLine("Name       Price");
			foreach (Item item in ItemStock)
			{
				double PoundFormat = item.Price / 100;
				Console.WriteLine("{0}       £{1:0.00}", item.Name, PoundFormat);
			}
		}

		//public void Select(string itemName)
		//{
		//	foreach (Item item in )
		//}
		
		   
		private double TotalOfUserCoins(List<Coin> coinList)
		{
			return coinList.Sum(coin => coin.Value);
		}

	}
}