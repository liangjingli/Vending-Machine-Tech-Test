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
			DisplayUserCoins(coin);
			CalculateCoinsToPay();

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

		public void Select(string itemName)
		{
			FindItemWithName(itemName);
			double TotalPrice = Selection.Sum(item => item.Price) / 100;
			Console.WriteLine("Total Price £{0:0.00}", TotalPrice);
		}

		private void FindItemWithName(string itemName)
		{
			Item ItemToRemove = null;
			foreach (Item item in ItemStock)
			{
				if (item.Name == itemName)
				{
					ItemToRemove = item;
					Console.WriteLine("You Have Selected {0}", item.Name);
					Selection.Add(item);
					break;
				}
			}

			if (ItemToRemove != null)
			{
				ItemStock.Remove(ItemToRemove);
			}
		}

		private void DisplayUserCoins(Coin coin)
		{
			double PoundFormat = coin.Value / 100;
			double UserCoinsTotal = VendorCoinManger.UserCoinsTotal() / 100;
			Console.WriteLine("You Have Inserted £{0:0.00}", PoundFormat);
			Console.WriteLine("Your Total £{0:0.00}", UserCoinsTotal);
		}

		private void CalculateCoinsToPay()
		{
			double TotalPrice = Selection.Sum(item => item.Price);
			double UserCoinsTotal = VendorCoinManger.UserCoinsTotal();
			double CoinsToPay = Math.Ceiling(TotalPrice / UserCoinsTotal) - 1;

			Console.WriteLine("Please Insert {0} more coin(s) To Complete purchase", CoinsToPay);
		}

	}
}