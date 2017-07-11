using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineProject
{
    public class CoinManager
    {
		public static Coin[] ValidUserCoins = { new Coin(50) };

		public List<Coin> UserCoins { get; set; }
		public List<Coin> CoinsToReturn { get; set; }
		public List<Coin> CoinStock { get; set; }

		public CoinManager()
		{
			List<Coin> coinStock = new List<Coin> { new Coin(20),
													new Coin(10),
													new Coin(10),
													new Coin(20),
													new Coin(20)
			};
			CoinStock = coinStock;
			UserCoins = new List<Coin>();
			CoinsToReturn = new List<Coin>();
		}

		public void Insert(Coin coin)
		{
			if (!IsValid(coin))
			{
				throw new ArgumentException("Only accpets 50p coins");
			}
			UserCoins.Add(coin);
		}

		public void GiveChange(double price)
		{
			double Remainder = RemainderFromUserCoins(price);
			int NumberOfCoinsToRemove = 0;
			foreach (Coin coin in CoinStock)
			{
				if (-Remainder >= coin.Value)
				{
					Remainder += coin.Value;
					CoinsToReturn.Add(coin);
					NumberOfCoinsToRemove++;
				}
			}
			CoinStock.RemoveRange(0, NumberOfCoinsToRemove);
		}

		private double RemainderFromUserCoins(double price)
		{
			double Remainder = 0;
			double totalCoins = 0;
			foreach (Coin coin in UserCoins)
			{
				Remainder = price - totalCoins - coin.Value;
				totalCoins += coin.Value;
			}
			CoinStock.AddRange(UserCoins);
			UserCoins.Clear();
			return Remainder;
		}

		private bool IsValid(Coin PassedCoin)
		{
			bool Valid = false;
			foreach (Coin coin in ValidUserCoins)
			{
				if (coin.Value == PassedCoin.Value)
				{
					Valid = true;
					break;
				}
			}
			return Valid;
		}
	}
}
