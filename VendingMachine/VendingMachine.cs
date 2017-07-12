using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineProject
{

    public class VendingMachine
    {
		public List<Item> ItemStock { get; private set; }
		public List<Item> Selection { get; private set; }
		public CoinManager VendorCoinManger { get; set; }
		public bool SufficientPayment { get; set; }

		public VendingMachine()
		{
			List<Item> itemStock = new List<Item> { new Item("water", 60),
													new Item("water", 60),
													new Item("water", 60),
													new Item("crisps", 40),
													new Item("crisps", 40),
													new Item("crisps", 40)
			};

			ItemStock = itemStock;
			Selection = new List<Item>();
			VendorCoinManger = new CoinManager();
			SufficientPayment = false;
		}

		public void Insert(Coin coin)
		{
			VendorCoinManger.Insert(coin);
			DisplayUserCoins(coin);
			Console.WriteLine("Total Price £{0:0.00}", SelectionTotalPrice() / 100);
			CalculateCoinsToPay();
			double TotalPrice = SelectionTotalPrice();
			Vend(TotalPrice);
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
			Console.WriteLine("Total Paid £{0:0.00}", UserCoinsTotal);
		}

		public void DisplayItemsInSelection()
		{
			int WaterCount = Selection.Count(item => item.Name == "water");
			int CrispCount = Selection.Count(item => item.Name == "crisps");
			Console.WriteLine("Your Items(s):");
			if (WaterCount > 0) Console.WriteLine("{0}x water", WaterCount);
			if (CrispCount > 0) Console.WriteLine("{0}x crisps", CrispCount);
		}

		private void CalculateCoinsToPay()
		{
			double TotalPrice = SelectionTotalPrice();
			double UserCoinsTotal = VendorCoinManger.UserCoinsTotal();
			double CoinsToPay = Math.Floor(TotalPrice / UserCoinsTotal);
			if (CoinsToPay <= 0) SufficientPayment = true;
			if (CoinsToPay > 0) Console.WriteLine("Please Insert more coins To Complete purchase");
		}

		public void Vend(double price)
		{
			if (SufficientPayment)
			{
				double Change = VendorCoinManger.GiveChange(price) / 100;
				VendorCoinManger.CoinsToReturn.Clear();
				DisplayItemsInSelection();
				Selection.Clear();
				Console.WriteLine("Your Change: £{0:0.00}", Change);
			}
			SufficientPayment = false;
		}

		private double SelectionTotalPrice()
		{
			return Selection.Sum(item => item.Price);
		}

	}
}