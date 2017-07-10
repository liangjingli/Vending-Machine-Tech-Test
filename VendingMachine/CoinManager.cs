using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class CoinManager
    {
		public static Coin[] ValidUserCoins = { new Coin(0.50) };
		private List<Coin> _coinsToReturn = new List<Coin>();
		private List<Coin> _userCoins = new List<Coin>();
		private List<Coin> _coinStock = new List<Coin>{ new Coin(0.20),
														new Coin(0.10),
														new Coin(0.10),
														new Coin(0.20),
														new Coin(0.20) };

		public List<Coin> UserCoins
		{
			get { return _userCoins; }
			set { _userCoins = value; }
		}

		public List<Coin> CoinsToReturn
		{
			get { return _coinsToReturn; }
			set { _coinsToReturn = value; }
		}

		public List<Coin> CoinStock
		{
			get { return _coinStock; }
			set { _coinStock = value; }
		}

		public CoinManager()
		{
			this.CoinStock = CoinStock;
			this.UserCoins = UserCoins;
		}

		public void Insert(Coin coin)
		{
			if (!IsValid(coin))
			{
				throw new ArgumentException("Only accpets 50p coins");
			}
			UserCoins.Add(coin);
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
