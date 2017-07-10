using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class CoinManager
    {
		public static Coin[] ValidUserCoins = { new Coin(0.50) };

		public List<Coin> UserCoins { get; set; }
		public List<Coin> CoinsToReturn { get; set; }
		public List<Coin> CoinStock { get; set; }

		public CoinManager()
		{
			List<Coin> coinStock = new List<Coin> { new Coin(0.20),
													new Coin(0.10),
													new Coin(0.10),
													new Coin(0.20),
													new Coin(0.20)
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

		public double RemainderFromUserCoins(double price)
		{
			double Remainder;
			while (true)
			{
				Remainder = price - UserCoins.First().Value;
				Coin coin = UserCoins.First();
				UserCoins.RemoveAt(0);
				CoinStock.Add(coin);
				
				if (Remainder < 0)
				{
					break;
				}

			}
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
